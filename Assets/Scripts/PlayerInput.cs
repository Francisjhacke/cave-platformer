using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float runSpeed = 40.0f;

    private CharacterController2D controller;
    //private Animator animator;

    private float horizontalMove = 0.0f;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        //animator.SetFloat("speed", horizontalMove);
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            //animator.SetBool("isJumping", true);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;
    }

}
