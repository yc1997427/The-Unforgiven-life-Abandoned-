using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    private Vector3 offset;
    public float speed;
    private Rigidbody rb;

    void Start(){
    	offset=transform.position;
        rb=GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
    	transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    	float dist=Vector3.Distance(player.transform.position,transform.position);

    	if (dist<20){
 
            int x=Random.Range(-1,1);
            int z=Random.Range(-1,1);
    		Vector3 movement=new Vector3(x,0,z);
            rb.MovePosition(transform.position+(player.transform.forward*Time.deltaTime*speed));

    	}

    }
}
