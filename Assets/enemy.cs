using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour{
    Transform player;
    public Rigidbody rigidbody;
    public int i;
    void OnTriggerEnter(Collider collision){
        i = GameObject.Find("unitychan").GetComponent<unitychancode>().i;         
    	if(collision.gameObject.name == "Katana_LODA" && i==1){
        	Destroy(this.gameObject);
        	Debug.Log(i);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        GetComponent<Renderer>().material.color = Color.green;
        player = GameObject.Find("unitychan").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
	this.rigidbody.velocity = (player.position
 - this.transform.position);
    }
}
