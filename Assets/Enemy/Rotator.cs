using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    private Vector3 offset;
    public float speed;

    void Start(){
    	offset=transform.position;
    }
    // Update is called once per frame
    void Update()
    {
    	transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    	float dist=Vector3.Distance(player.transform.position,transform.position);

    	if (dist<10){

    		Vector3 movement=new Vector3(2,0,2);
            transform.position=transform.position+(movement *speed);

    	}

    }
}
