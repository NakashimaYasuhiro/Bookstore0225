using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> bookList = new List<string>();
        bookList.Add("B1");
        bookList.Add("B2");
        bookList.Add("B3");
        bookList.Add("B4");
        bookList.Add("B5");
        bookList.Add("B6");
        bookList.Add("B7");
        bookList.Add("B8");
        bookList.Add("B9");
        bookList.Add("B10");

        //2次元配列？とかいうのにすれば、サイズ情報と紹介文情報を格納できる？

        //Debug.Log(bookList[9]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
