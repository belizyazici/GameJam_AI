using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    public float runSpeed = 3.0f;
    public float turnSpeed = 1.5f;
    private float horizontalInput;
    public CharacterController _controller;
    
    public float jumpSpeed = 4.0f;
   
    bool isGrounded;
    private float verticalSpeed;
    public float gravity = 9.81f;

    void Start()
    {
        animator = transform.GetComponent<Animator>();
        _controller = transform.GetComponent<CharacterController>();

    }

    void Update()
    {
        Walk();
        Jump();
        Turn();
        
    }
  
    private void Walk()
    {
    

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
            Turn();
            _controller.Move(transform.forward * runSpeed * Time.deltaTime);

        }
    
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isRunning", false);
        }
    }
  
    private void Turn()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // turn left
            transform.Rotate(0, -90 * Time.deltaTime, 0);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            // turn right
            transform.Rotate(0, 90 * Time.deltaTime, 0);
        }
    
    }
    
    private void Jump()
    {
        isGrounded = _controller.isGrounded;

        if (!isGrounded)
        {
            verticalSpeed -= gravity * Time.deltaTime;
        }
        else
        {
            verticalSpeed = -gravity * Time.deltaTime;

            if (Input.GetKey(KeyCode.Space))
            {
                verticalSpeed = Mathf.Sqrt(2f * jumpSpeed * gravity);
            }
        }

        _controller.Move(new Vector3(0, verticalSpeed, 0) * Time.deltaTime);
  
    }
}
