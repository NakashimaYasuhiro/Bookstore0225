using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Image sampleImage;
    public Sprite bookPOP;

    void Start()
    {
        sampleImage.sprite = bookPOP;
    }

   
    void Update()
    {
        
    }
}
