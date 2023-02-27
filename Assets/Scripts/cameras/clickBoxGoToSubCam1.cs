using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBoxGoToSubCam1 : MonoBehaviour
{

    public GameObject maincam;
    public GameObject subcam1;
    // Start is called before the first frame update
    void Start()
    {
        maincam.SetActive(true);
        subcam1.SetActive(false);
        Debug.Log("clickChangeCamera started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToSubCam1()
    {
        Debug.Log("ChangeToSubCam1 function");    

         if (maincam)
        {
            maincam.SetActive(false);
            subcam1.SetActive(true);
        }
    }

}
