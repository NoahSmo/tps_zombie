using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementBehaviour : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    
    [SerializeField]
    private Animator animator;
    
    CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 9.0F;
            animator.SetBool("isRunning", true);
        }
        else
        {
            speed = 6.0F;
            
            animator.SetBool("isRunning", false);
        }

        float horizontalSpeed = Input.GetAxis("Horizontal");
        float verticalSpeed = Input.GetAxis("Vertical");
        
        animator.SetFloat("Speed", speed);
        animator.SetFloat("VelocityX", horizontalSpeed);
        animator.SetFloat("VelocityZ", verticalSpeed);
        
        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        
        
        if ( Input.GetMouseButtonDown( 0 ) )
        {
            animator.SetTrigger("Attack");
        }
    }
}
