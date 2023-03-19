using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickURL : MonoBehaviour
{
    [SerializeField] ZoomClickedBook zoomClickedBook;
    public string pickedurl;

    private void Start()
    {
        pickedurl = null;
    }


    public void onClick()
    {  
        pickedurl = zoomClickedBook.pickedItem.url;
        
        Debug.Log("url:"+pickedurl) ;

        Application.OpenURL(pickedurl);
       
    }
}
