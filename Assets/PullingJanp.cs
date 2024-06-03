using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PullingJanp : MonoBehaviour
{

    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            //クリックした座標と離した座標の差分を取得
            Vector3 dist = clickPosition - Input.mousePosition;

            //クリックとリリースが同じ座標ならば無視
            if (dist.sqrMagnitude == 0) { return; }

            //差分を標準化しjumpPowerをかけ合わせた値を移動量とする
            rb.velocity = dist.normalized * jumpPower;
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.velocity = new Vector3(0, 10, 0);

        //}


    }
}
