using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class subCam1Controller : MonoBehaviour
{
    public GameObject maincam;
    public GameObject subcam1;


    void Start()
    {
        
    }

   
    void Update()
    {
        if(subcam1.activeSelf)   
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                 Debug.Log("spacekey was pushed");
            

                 Debug.Log(maincam.activeSelf);
           
                //maincam.SetActive(true);
                // subcam1.SetActive(false);
                // Debug.Log(maincam.activeSelf);
             
             }

            /*
             if(Input.GetMouseButtonDown(0))
             {
                  Debug.Log("ClickAndChangeCamera worked");

                  subcam1.SetActive(false);
                  maincam.SetActive(true);   
             } 
             */
        }    
        
            
    } 

}
    

    

