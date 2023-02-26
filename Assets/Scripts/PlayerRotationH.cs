using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotationH : MonoBehaviour
{
    public InputAction inputRotationH;
    public Vector2 rotationHValue;
    public float m_fSpeed = 0.05f;
    private void OnEnable()
    {
        inputRotationH.Enable();
    }

    private void OnDisable()
    {
        inputRotationH.Disable();
    }

    void start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationHValue = inputRotationH.ReadValue<Vector2>();
        transform.Rotate(
           0.0f,
           rotationHValue.x * m_fSpeed,
           0.0f);
    }
}
