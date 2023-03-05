using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] GameObject firstpanel;
    public InputAction m_inputMover;
    public Vector2 m_movementValue;
    public float m_fSpeed = 0.01f;


    void Start()
    {
        firstpanel.SetActive(true);
        m_movementValue = m_inputMover.ReadValue<Vector2>();
        transform.position = new Vector3(8f, 1.23f, -3.38f);
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


    public void StartShopFromInside()
    {
        firstpanel.SetActive(false);
        transform.position = new Vector3(9f, 1.14f, 4f);
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
}
