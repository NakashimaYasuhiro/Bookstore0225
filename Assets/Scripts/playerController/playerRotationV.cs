using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerRotationV : MonoBehaviour
{
    public InputAction m_inputRotation;
    public Vector2 m_rotationValue;
    public float m_fSpeed = 0.5f;
    private void OnEnable()
    {
        m_inputRotation.Enable();
    }

    private void OnDisable()
    {
        m_inputRotation.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_rotationValue = m_inputRotation.ReadValue<Vector2>();

            transform.Rotate(
            -m_rotationValue.y * m_fSpeed,
            0.0f,
            0.0f);


    }
}
