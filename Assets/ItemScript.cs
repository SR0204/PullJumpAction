using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private AudioSource audioSource;


    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        //DestroySelf();

        animator.SetTrigger("Get");
        audioSource.Play();

       
        //Debug.Log("Enter");
    }
    private void OnTriggerStay(Collider other)
    {
       
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        
        Debug.Log("Exit");
    }

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();//?????
    }

    // Update is called once per frame
    void Update()
    {

    }
}
