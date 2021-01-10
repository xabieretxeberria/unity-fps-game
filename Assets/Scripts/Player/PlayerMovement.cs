using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private PlayerRun run;
    private PlayerJump jump;

    private Vector3 movement;
    private float movementSpeed;

    [SerializeField]
    private float walkingSpeed;

    [SerializeField]
    private float runningSpeed;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        run = GetComponent<PlayerRun>();
        jump = GetComponent<PlayerJump>();
    }

    void Update()
    {
        movement.y -= jump.getGravity();
        characterController.Move(movement * Time.deltaTime);

        if (!characterController.isGrounded) return;

        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement = transform.TransformDirection(movement);

        movementSpeed = run.isRunning() ? runningSpeed : walkingSpeed;
        movement *= movementSpeed;

        if (jump.isJumping()) {
            movement.y += jump.getJumpForce();
        }
    }
}
