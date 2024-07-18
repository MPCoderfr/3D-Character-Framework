using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Orientation")]
    public Transform orientation;

    #region Public Fields:
    [Header("Movement")]
    public float moveSpeed;

    [Header("Jump")]
    public float JumpHeight;
    #endregion

    float horizInput;
    float vertInput;
    Vector3 moveDirect;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        KeyInputs();
    }
    public void KeyInputs()
    {
        horizInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
    }

    public void MovePlayer()
    {
        moveDirect = 
    }
}
