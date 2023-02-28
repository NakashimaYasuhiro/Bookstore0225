using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBoxGoToSubCam1 : MonoBehaviour
{

    public GameObject maincam;
    public GameObject subcam1;
    public GameObject subcam2;

    //call function from other class
    public cameraTest cameratest;

    void Start()
    {
        /*
        maincam.SetActive(true);
        subcam1.SetActive(false);
        subcam2.SetActive(false);
        Debug.Log("clickChangeCamera started");
        */
    }

    
    void Update()
    {
        
    }

    public void ChangeToSubCam1()
    {
        Debug.Log("ChangeToSubCam1 function");
        cameratest.Subcam1StageF();

        /*
         if (maincam.activeSelf)
        {
            maincam.SetActive(false);
            subcam1.SetActive(true);
        }
        */
    }

}
