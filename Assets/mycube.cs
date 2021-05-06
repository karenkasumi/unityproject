using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mycube : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Sphere"){
        	SceneManager.LoadScene("gameover");
        }
    }
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
        this.transform.position += new Vector3(0, 0, 0.1f);
        }
        if(Input.GetKey("s")){
        this.transform.position += new Vector3(0, 0, -0.1f);
        }  
        if(Input.GetKey("a")){
        this.transform.position += new Vector3(-0.1f, 0, 0);
        }    
        if(Input.GetKey("d")){
        this.transform.position += new Vector3(0.1f, 0, 0);
        }
        /*if(Input.GetKeyDown("space")){
        this.rigidbody.velocity = new Vector3(0, 10, 0 );
        }*/
        if(this.transform.position.y<-3){
        	SceneManager.LoadScene("gameover");
        }
        
    }
    void OnCollisionStay(Collision collision){
    	if(collision.gameObject.name == "Plane"){
    		if(Input.GetKeyDown("space")){
        	this.rigidbody.velocity = new Vector3(0, 10, 0 );
        	}
    	}
    }
}
