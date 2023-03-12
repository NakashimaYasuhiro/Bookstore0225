using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UI;


public class ZoomClickedBook : MonoBehaviour
{


    GameObject clickedbook;
    public GameObject maincam, subcam1, subcam2;
    Vector3 subcam2posi;

    public CameraStatus camerastatus;
    

    [SerializeField] GameObject panel;
    public GameObject cloneObject;
    public Transform objParent;
    public Vector3 scale;

    public CloseCanvas closecanvas;

    //List用
    [SerializeField] ItemDataBase itemDatabase;

    public ItemData pickedItem;
    
    //public Sprite sourceimage;
    //public GameObject showBookImage;
    //List用ここまで


    void Start()
    {
        //ItemListの呼び出し
        //sourceimage = showBookImage.GetComponent<Image>().sprite;
        //Debug.Log(sourceimage.name);

        //Debug.Log(itemDatabase.itemDatas[0].name);
        int listcount = itemDatabase.itemDatas.Count;
        //Debug.Log(listcount);
        //itemDatabase.itemDatas.Add();

        //itemDatabase.itemDatas.RemoveAt(0);
        //ItemData na = itemDatabase.itemDatas.Contains("ゆっくり、いそげ");
        //ItemData pickeditem = itemDatabase.itemDatas.Find(item => item.name == clickedbook.name);
        //Debug.Log("クリックしたアイテムをListの中から探し出した"+pickeditem.name);


        //ここまでItemListの呼び出し

        subcam2posi = subcam2.transform.position;


    }

    
    void Update()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            if (camerastatus.subcam2Stage)
            {
                closecanvas.ClosePanel();
                
                camerastatus.MaincamStageF();
               // Debug.Log("CameraStatus.maincamStage:"+camerastatus.maincamStage);
            }
            else if (camerastatus.maincamStage)
            {
                clickedbook = null;
                //Debug.Log("maincamstage in else if");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {

                    clickedbook = hit.collider.gameObject;
                   


                    if (clickedbook.tag == "book") {
                        Vector3 transformposi = clickedbook.GetComponent<Transform>().position;
                        //Debug.Log(clickedbook.name);
                        
                        //動くけどエラーが発生するので直したい
                        pickedItem = itemDatabase.itemDatas.Find(item => item.name == clickedbook.name);
                        Debug.Log("clickedbookをListの中から探し出した→List上の名前:" + pickedItem.name);
                        int pickedItemIndex = itemDatabase.itemDatas.IndexOf(pickedItem);
                        Debug.Log(pickedItemIndex);

                        ShowPanel();
                        if (cloneObject != null)
                        {
                            Debug.Log(cloneObject);
                        }
                        else { Debug.Log("cloneobject null"); }
                         
                                              

                    }

                }

            }
            else if (camerastatus.subcam1Stage)
            {
                clickedbook = null;
                Debug.Log("subcam1stage in else if");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {

                    clickedbook = hit.collider.gameObject;

                    

                    if (clickedbook.tag == "book")
                    {                        
                        ShowPanel();

                        if (cloneObject != null)
                        {
                            Debug.Log(cloneObject);
                        }
                        else { Debug.Log("cloneobject null"); }
                       
                       

                    }

                }

            }


        }
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
        camerastatus.Subcam2StageF();
        cloneObject = Instantiate(clickedbook, objParent);        
    
                   
        cloneObject.transform.localScale = new Vector3(500, 700, 1);
        cloneObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
       
   
    }





}
