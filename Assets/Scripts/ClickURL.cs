using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickURL : MonoBehaviour
{
    public void ClickBookURL()
    {
        Application.OpenURL("https://www.google.co.jp/");
    }
}
