using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public InputAction m_inputMover;
    public Vector2 m_movementValue;
    public float m_fSpeed = 0.01f;
    
    private void OnEnable()
    {
        m_inputMover.Enable();    
    }

    private void OnDisable()
    {
        m_inputMover.Disable();
    }



    void Start()
    {
       
    }

    void Update()
    {
        m_movementValue = m_inputMover.ReadValue<Vector2>();     
        transform.Translate(
            m_movementValue.x * m_fSpeed,
            0.0f,
            m_movementValue.y * m_fSpeed
        );   
    }
}
