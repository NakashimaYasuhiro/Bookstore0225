using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class CloseCanvas : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public ZoomClickedBook cameramanager;
    [SerializeField] CameraStatus status;
        


    public void ClosePanel()
    {
        Debug.Log("closepanel worked!");
        //Debug.Log("cameramanager.cloneObject:"+cameramanager.cloneObject);   
        Destroy(cameramanager.cloneObject);
        //panel.SetActive(false);
        status.MaincamStageF();

       



       
        
    }
}

