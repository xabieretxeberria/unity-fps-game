using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private CharacterController characterController;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float gravity;

    private bool jumping;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();    
    }

    void Update()
    {
        jumping = Input.GetButtonDown("Jump");
    }

    public bool isJumping()
    {
        return jumping;
    }

    public float getJumpForce()
    {
        return jumpForce;
    }

    public float getGravity()
    {
        return gravity;
    }
}
