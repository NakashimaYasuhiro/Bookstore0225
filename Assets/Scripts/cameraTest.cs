using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTest : MonoBehaviour


{
    public GameObject maincam;
    public GameObject subcam1;
    public GameObject subcam2;
    private bool maincamStage = true;
    private bool subcam1Stage = false;
    private bool subcam2Stage = false;
    
    void Start()
    {

        maincam.SetActive(true);
        subcam1.SetActive(false);
        subcam2.SetActive(false);

        Debug.Log("maincam.activeSelf" + maincam.activeSelf);
        Debug.Log("subcam1.activeSelf" + subcam1.activeSelf);
        Debug.Log("subcam2.activeSelf" + subcam2.activeSelf);

        maincamStage = true;

        


    }

    // Update is called once per frame
    void Update()
    {
        
        if (maincamStage) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Subcam1StageF();
            }
        
        }    
        else if (subcam1Stage)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                MaincamStageF();
            }

        }
       

    }

          public void MaincamStageF()
          {
               Debug.Log("MaincamStage");
               maincam.SetActive(true);
               subcam1.SetActive(false);
               subcam2.SetActive(false);
               maincamStage = true;
               subcam1Stage = false;
               subcam2Stage = false;   

           }

           public void Subcam1StageF()
           {
                 Debug.Log("Subcam1Stage");
                 maincam.SetActive(false);
                 subcam1.SetActive(true);
                 subcam2.SetActive(false);

                 maincamStage = false;
                 subcam1Stage = true;
                 subcam2Stage = false;
    }

          public void Subcam2StageF()
           {
              Debug.Log("Subcam2Stage");
              maincam.SetActive(false);
              subcam1.SetActive(false);
              subcam2.SetActive(true);
              maincamStage = false;
              subcam1Stage = false;
              subcam2Stage = true;
    }       


}
