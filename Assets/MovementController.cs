using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 30f;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            if (Input.GetKey("left shift"))
            {
                controller.Move(direction * speed * 2f * Time.deltaTime);

            }
            else
            {
                controller.Move(direction * speed * Time.deltaTime);

            }
        }
    }
}
