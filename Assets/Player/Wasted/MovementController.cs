﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 1f;
    public CharacterController controller;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            if (Input.GetKey("left shift"))
            {
                controller.Move(direction * speed * 1.7f * Time.deltaTime);

            }
            else
            {
                controller.Move(direction * speed * Time.deltaTime);

            }
        }
    }
}
