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
        bool w_pressed = Input.GetKey("w");
        bool s_pressed = Input.GetKey("s");
        bool shift_pressed = Input.GetKey("left shift");
        // when player presses w
        if (!isJogging && w_pressed)
        {
            //set isRunning to true 
            animator.SetBool("isJogging", true);
        }

        if (isJogging && !w_pressed)
        {
            //set isRunning to false 
            animator.SetBool("isJogging", false);
        }
        
        if (!isRunning && (shift_pressed && w_pressed))
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && (!shift_pressed || !w_pressed))
        {
            animator.SetBool("isRunning", false);
        }


        if (!isBackwards && s_pressed)
        {
            //set isRunning to true 
            animator.SetBool("isBackwards", true);
        }

        if (isBackwards && !s_pressed)
        {
            //set isRunning to false 
            animator.SetBool("isBackwards", false);
        }

    }
}
