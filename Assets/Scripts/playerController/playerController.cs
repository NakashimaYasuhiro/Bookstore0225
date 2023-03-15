using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] GameObject firstpanel;
    public InputAction m_inputMover;
    public Vector2 m_movementValue;
    public float m_fSpeed = 0.2f;
    // Vector3 targetPos;

    //RayÇîÚÇŒÇ∑Ç‚Ç¬
    //public Transform shotDirection;

    //[SerializeField] LayerMask solidObjectsLayer;

    //rigidbodyÇ…ÇÊÇÈà⁄ìÆ
    Vector3 movingDirecion;
    public float speedMagnification; //í≤êÆïKóvÅ@ó·10
    public Rigidbody rb;
    public Vector3 movingVelocity;
 
    //Ç±Ç±Ç‹Ç≈
    void Start()
    {
        firstpanel.SetActive(true);

        /*
        m_movementValue = m_inputMover.ReadValue<Vector2>();
        transform.position = new Vector3(8f, 1.23f, -3.38f);
        */
        //rigidbodyÇ…ÇÊÇÈà⁄ìÆ
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //Debug.DrawRay(shotDirection.position, shotDirection.transform.forward, Color.green);

        /*
        m_movementValue = m_inputMover.ReadValue<Vector2>();

        transform.Translate(
            m_movementValue.x * m_fSpeed * Time.deltaTime,
            0.0f,
            m_movementValue.y * m_fSpeed * Time.deltaTime
        );
        */

        //transform.position = targetPos;

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        movingDirecion = new Vector3(x, 0, z);
        movingDirecion.Normalize();//éŒÇﬂÇÃãóó£Ç™í∑Ç≠Ç»ÇÈÇÃÇñhÇ¨Ç‹Ç∑
        movingVelocity = movingDirecion * speedMagnification;
        if (Input.anyKey)
        {
            movingVelocity = movingDirecion * speedMagnification;
        }
        else if (!Input.anyKey)
        {
            rb.velocity = Vector3.zero;
        }
    }
    void FixedUpdate()
    {

        rb.velocity = new Vector3(movingVelocity.x, rb.velocity.y, movingVelocity.z);
    }

    public void StartShopFromInside()
    {
        firstpanel.SetActive(false);
        transform.position = new Vector3(9f, 1.12f, 5.59f);
    }

    public void StartShopFromOutside()
    {
        firstpanel.SetActive(false);
        transform.position = new Vector3(7.5f, 1.2f, -3f);
    }

    private void OnEnable()
    {
        m_inputMover.Enable();
    }

    private void OnDisable()
    {
        m_inputMover.Disable();
    }


    /*
    public bool Shooting()
    {
        
        RaycastHit hitInfo;
        if (Physics.Raycast(shotDirection.transform.position,shotDirection.transform.forward, out hitInfo,1f))
        {
            if(hitInfo.collider != null) 
            {
               
                Debug.Log("âΩÇ©Ç…ìñÇΩÇ¡ÇΩ");
                
            }

        }
        
     }*/

    //bool IsWalkable(Vector3 targetPos)
    //{
    //    return Physics2D.OverlapCircle(targetPos, 0.2f, solidObjectsLayer)==false;
    //}
}
