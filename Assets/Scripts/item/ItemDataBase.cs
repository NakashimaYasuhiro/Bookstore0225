using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Assets/Databases/Item Database")]
public class ItemDataBase : ScriptableObject
{
    public List<ItemData> itemDatas = new List<ItemData>();

    //public string objectName;
}

[System.Serializable]
public class ItemData
{
    public string name;
    public string url;
    
    public Sprite sprite;
    [TextArea]
    public string text;
}


