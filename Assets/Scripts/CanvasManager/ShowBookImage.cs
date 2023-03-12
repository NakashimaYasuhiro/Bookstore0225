using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBookImage : MonoBehaviour
{
    public Image pickedbookImage;
    public ZoomClickedBook zoomclickedbook;
    [SerializeField] ItemDataBase itemDatabase;
    Sprite sourceimage;
    
    void Start()
    {
       // sourceimage = GetComponent<Image>().sprite;
       // ItemData pickedItem = zoomclickedbook.pickedItem;
       // Debug.Log("ShowBookImage:" + pickedItem.name);
       // sourceimage = pickedItem.sprite;
       // Debug.Log("sourceimage:" + sourceimage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
