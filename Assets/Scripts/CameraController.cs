using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;

    public float mouseSensitivity=100f;

    public Transform playerBody;
    float xRotation=0f;


    void Start()
    {
    	offset=transform.position;
        Cursor.lockState=CursorLockMode.Locked;
        
    }
    void Update(){
        float mouseX=Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY=Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;

        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);
        transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up*mouseX);
    }


    // Update is called once per frame
    void LateUpdate()
    {
    	transform.position=player.transform.position+offset;   
    }


}
