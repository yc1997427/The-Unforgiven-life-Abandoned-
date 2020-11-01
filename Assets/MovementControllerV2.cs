using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerV2 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKey("left shift"))
        {
            Vector3 playerMovement = new Vector3(horizontal, 0f, vertical) * speed * 1.5f * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        else
        {
            Vector3 playerMovement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        
        
    }
}
