using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    public Vector3 angle_offset;
    public Vector3 position_offset;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; //Hide cursor
        Cursor.lockState = CursorLockMode.Locked; //Keep cursor centered
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed; //Get mouse X axis input
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed; //Get mouse Y axis input
        mouseY = Mathf.Clamp(mouseY, -35, 60); //Avoiding awkward angles
        transform.LookAt(Target.position + angle_offset);
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0); //To rotate the camera
        Player.rotation = Quaternion.Euler(0, mouseX, 0); //To rotate the player with the camera
    }
}
