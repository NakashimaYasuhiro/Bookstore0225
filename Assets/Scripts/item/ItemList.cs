using UnityEngine;
using System.Collections.Generic;

public class ItemList : MonoBehaviour
{

    public GameObject itemObject;
   
    public Sprite itemImage;
    public string itemURL;
    public string itemDescription;

    public List<ItemData> items;

    void Start()
    {
        //items = new List<ItemData>();
        //items.Add(new ItemData
       // {

           // itemObject = null,
           // itemName = "Item 1",
           // itemImage = Resources.Load<Sprite>("�������A������"),
           // itemURL = "http://example.com/item1",
           // itemDescription = "This is item 1."
       // });
       // items.Add(new ItemData
       // {
      //      itemName = "Item 2",
    //        itemImage = Resources.Load<Sprite>("item2"),
      //      itemURL = "http://example.com/item2",
       //     itemDescription = "This is item 2."
     //   });


        Debug.Log(items[0].itemObject);
        
        Debug.Log(items[0].itemURL);
        Debug.Log(items[0].itemDescription);
        Application.OpenURL(items[0].itemURL);

        //�N���b�N�����I�u�W�F�N�g�̃��X�g��������itemURL,itemDescription���擾


    }

}
