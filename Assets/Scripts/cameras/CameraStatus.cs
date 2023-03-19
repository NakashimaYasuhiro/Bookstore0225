using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStatus : MonoBehaviour
{
    public GameObject maincam;
    public GameObject subcam1;
    public GameObject subcam2;
    public bool maincamStage = true;
    public bool subcam1Stage = false;
    public bool subcam2Stage = false;

    void Start()
    {

        maincam.SetActive(true);
        subcam1.SetActive(false);
        subcam2.SetActive(false);

       // Debug.Log("maincam.activeSelf" + maincam.activeSelf);
        //Debug.Log("subcam1.activeSelf" + subcam1.activeSelf);
        //Debug.Log("subcam2.activeSelf" + subcam2.activeSelf);

        maincamStage = true;

    }

 
    void Update()
    {
        /*
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
        else if (subcam2Stage)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                MaincamStageF();
            }

        }
        */

    }

    public void MaincamStageF()
    {
        
        maincam.SetActive(true);
        subcam1.SetActive(false);
        subcam2.SetActive(false);
        maincamStage = true;
        subcam1Stage = false;
        subcam2Stage = false;
        Debug.Log("åªç›maincam true");
    }

    public void Subcam1StageF()
    {
        
        maincam.SetActive(false);
        subcam1.SetActive(true);
        subcam2.SetActive(false);

        maincamStage = false;
        subcam1Stage = true;
        subcam2Stage = false;
        Debug.Log("åªç›subcam1 true");
    }

    public void Subcam2StageF()
    {
        
        maincam.SetActive(false);
        subcam1.SetActive(false);
        subcam2.SetActive(true);
        maincamStage = false;
        subcam1Stage = false;
        subcam2Stage = true;
        Debug.Log("åªç›subcam2 true");

    }


}
