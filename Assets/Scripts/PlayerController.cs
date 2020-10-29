using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private GameObject GameController;

    void start(){

    }

    void FixedUpdate ()
    {
    	float horAxis = Input.GetAxis("Horizontal");
    	float verAxis = Input.GetAxis( "Vertical");
    	Vector3 movement= new Vector3(horAxis,0.0f, verAxis);

    	GetComponent<Rigidbody>().AddForce(movement*speed*Time.fixedDeltaTime);
    }

}
