using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    Animator animator;
    GameObject playerObj;
    Transform playerTransform;

    bool isOpen;



    private void Start()
    {
        animator = GetComponent<Animator>();
        playerObj = GameObject.Find("Player");
        playerTransform = playerObj.GetComponent<Transform>();
        Debug.Log("playerTransform;"+playerTransform.position);

        isOpen = false;
         
    }
    private void OnTriggerEnter(Collider other)
    {

        if (!isOpen) {

            if (other.tag == "Player")
            {
                Debug.Log("‚Ô‚Â‚©‚Á‚½‚æ");
                animator.SetTrigger("OpenTr");

                isOpen = true;

                Invoke("PlayerToRoom", 3f);
                Invoke("CloseDoor", 3f);


            }
        }
        
        
        
    }
    void PlayerToRoom()
    {
        playerTransform.position = new Vector3(9.66f, 1.13f, 4.62f);
    }

    void CloseDoor()
    {
        animator.SetTrigger("CloseTr");
    }
    
}
