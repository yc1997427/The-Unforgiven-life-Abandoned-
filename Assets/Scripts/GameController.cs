using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed ;
    private int count;
    private int numHumans=4;
    public Text scoreText;
    public Text winText;
    public Text playPosition;

    public GameObject player;

    void Start()
    {
    	count=0;
    	winText.text="";
    	SetCountText();
    	SetPositionText();       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	SetPositionText();
    	SetCountText();
        
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="PickUp"){
    		other.gameObject.SetActive(false);
    		count++;
    		SetCountText();
    	}
    }

    public void SetCountText(){
    	scoreText.text="Score: "+count.ToString();
    	if(count>=numHumans){
    		winText.text="Group Bullying!";
    	}
    }
    public void SetPositionText(){
    	playPosition.text=player.transform.position.ToString("0.00");
    }
}
