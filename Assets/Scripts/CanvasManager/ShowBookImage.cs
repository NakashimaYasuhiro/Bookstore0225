using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBookImage : MonoBehaviour
{
    public Image pickedbookImage;
    public ZoomClickedBook zoomclickedbook;
    [SerializeField] ItemDataBase itemDatabase;
    Image sourceimage;
    
    void Start()
    {
       sourceimage = GetComponent<Image>();

       
       // Debug.Log("ShowBookImage:" + pickedItem.name);
      
       // Debug.Log("sourceimage:" + sourceimage);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetImage()
    {
        ItemData pickedItem = zoomclickedbook.pickedItem;
        sourceimage.sprite = pickedItem.sprite;
    }

}
