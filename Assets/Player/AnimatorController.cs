using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJogging = animator.GetBool("isJogging");
        bool isRunning = animator.GetBool("isRunning");
        bool isBackwards = animator.GetBool("isBackwards");
        bool isRight = animator.GetBool("isRight");
        bool isLeft = animator.GetBool("isLeft");
        bool isJumpUp = animator.GetBool("isJumpUp");
        bool w_pressed = Input.GetKey("w") || Input.GetKey("up");
        bool s_pressed = Input.GetKey("s") || Input.GetKey("down");
        bool a_pressed = Input.GetKey("a") || Input.GetKey("left");
        bool d_pressed = Input.GetKey("d") || Input.GetKey("right");
        bool shift_pressed = Input.GetKey("left shift");
        bool space_pressed = Input.GetKey("space");



        //BASIC MOVEMENT: 

        // when character isn't jogging and player presses w
        if (!isJogging && w_pressed)
        {
            //set isJogging to true (start forward jog animation)
            animator.SetBool("isJogging", true);
        }

        // when character is jogging and player leaves w
        if (isJogging && !w_pressed)
        {
            //set isJogging to true (stop forward jog animation)
            animator.SetBool("isJogging", false);
        }


        // when character isn't moving backwards and player presses s
        if (!isBackwards && s_pressed)
        {
            //set isBackwards to true (start backward movement animation)
            animator.SetBool("isBackwards", true);
        }

        // when character is moving backwards and player leaves s
        if (isBackwards && !s_pressed)
        {
            //set isBackwards to false (stop backward movement animation)
            animator.SetBool("isBackwards", false);
        }

        // when character isn't moving left and player presses a
        if (!isLeft && a_pressed)
        {
            //set isLeft to true (start left strafe animation)
            animator.SetBool("isLeft", true);
        }

        // when character is moving left and player leaves a
        if (isLeft && !a_pressed)
        {
            //set isLeft to false (stop left strafe animation) 
            animator.SetBool("isLeft", false);
        }

        // when character isn't moving right and player presses d
        if (!isRight && d_pressed)
        {
            //set isRight to true (start right strafe animation) 
            animator.SetBool("isRight", true);
        }

        // when character is moving right and player leaves d
        if (isRight && !d_pressed)
        {
            //set isRight to true (stop right strafe animation) 
            animator.SetBool("isRight", false);
        }


        //SPRINT:

        // when character isn't running and player presses left shift with w
        if (!isRunning && (shift_pressed && w_pressed))
        {
            // set isRunning to true (start forward run animation)
            animator.SetBool("isRunning", true);
        }

        // when character is running and player either leaves left shift or w
        if (isRunning && (!shift_pressed || !w_pressed))
        {
            // set isRunning to false (stop forward run animation)
            animator.SetBool("isRunning", false);
        }



        //JUMP:

        // when character isn't already in jump state and player presses spacebar
        if (!isJumpUp && space_pressed)
        {
            //set isJumpUp to true (start jump up animation)
            animator.SetBool("isJumpUp", true);
        }

            // when character is in the air and player leaves spacebar
            if (isJumpUp && !space_pressed)
        {
            //set isJumpUp to false (end jump up animation)
            animator.SetBool("isJumpUp", false);
        }

    }
}
