using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class ZoomClickedBook : MonoBehaviour
{
    GameObject clickedbook;
    public GameObject maincam, subcam1, subcam2;
    Vector3 subcam2posi;

    public CameraTest cameraTest; 

    void Start()
    {
        subcam2posi = subcam2.transform.position;
        Debug.Log(subcam2posi);

        //Debug.Log("maincamStage=" + cameraTest.maincamStage);
        //Debug.Log("subcam1Stage=" + cameraTest.subcam1Stage);
        //Debug.Log("subcam2Stage=" + cameraTest.subcam2Stage);

    }

    
    void Update()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            if (cameraTest.subcam2Stage)
            {
                Debug.Log("subcam2Stage = true");
                //
                //Maincam.GetComponent<Camera>().enabled = true;
                cameraTest.MaincamStageF();
                Debug.Log("cameraTest.maincamStage:"+cameraTest.maincamStage);
            }
            else if (cameraTest.maincamStage)
            {
                clickedbook = null;
                Debug.Log("maincamstage in else if");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {

                    clickedbook = hit.collider.gameObject;

                    //Debug.Log("クリックしたオブジェクトのタグは"+clickedbook.tag);

                    //Debug.Log(clickedbook);

                    if (clickedbook.tag == "book") {
                        Vector3 transformposi = clickedbook.GetComponent<Transform>().position;

                        subcam2.transform.position = new Vector3(transformposi.x, transformposi.y, transformposi.z - 1f);
                        cameraTest.Subcam2StageF();

                        //subcam2.SetActive(true);
                        //cameraTest.maincam.GetComponent<Camera>().enabled = false;


                        clickedbook = null;

                    }
                    
                }

            }
            else if (cameraTest.subcam1Stage)
            {
                clickedbook = null;
                Debug.Log("subcam1stage in else if");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {

                    clickedbook = hit.collider.gameObject;

                    //Debug.Log("クリックしたオブジェクトのタグは"+clickedbook.tag);

                    //Debug.Log(clickedbook);

                    if (clickedbook.tag == "book")
                    {
                        Vector3 transformposi = clickedbook.GetComponent<Transform>().position;

                        subcam2.transform.position = new Vector3(transformposi.x, transformposi.y, transformposi.z - 1f);
                        cameraTest.Subcam2StageF();

                        //subcam2.SetActive(true);
                        //cameraTest.maincam.GetComponent<Camera>().enabled = false;


                        clickedbook = null;

                    }

                }

            }


        }
    }
}
