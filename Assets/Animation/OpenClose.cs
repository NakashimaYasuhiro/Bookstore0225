using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    Animator animator;
    GameObject playerObj;
    Transform playerTransform;



    private void Start()
    {
        animator = GetComponent<Animator>();
        playerObj = GameObject.Find("Player");
        playerTransform = playerObj.GetComponent<Transform>();
        Debug.Log("playerTransform;"+playerTransform.position);
         
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("�Ԃ�������");
            animator.SetTrigger("OpenTr");
            playerObj.SetActive(false);
            Invoke("PlayerToRoom", 3f);
            playerObj.SetActive(true);


        }
        
    }
    void PlayerToRoom()
    {
        playerTransform.position = new Vector3(9.66f, 1.13f, 4.62f);
    }
    
}
