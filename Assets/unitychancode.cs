using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unitychancode : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    private Animator animator;
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Sphere"){
        	SceneManager.LoadScene("gameover");
        }
    }
　　public int i;
　　public void attack (int theValue) {
　　	if(theValue == 1){
		i=theValue;
	}
    }
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        //GetComponent<Renderer>().material.color = Color.red;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    	/*
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
        if(Input.GetKeyDown("space")){
        this.rigidbody.velocity = new Vector3(0, 10, 0 );
        }
        */
        if(this.transform.position.y<-3){
        	SceneManager.LoadScene("gameover");
        }
        if(Input.GetKeyDown("x")){
        	animator.SetTrigger("attack");
        }
	
        
        
    }
    /*void OnCollisionStay(Collision collision){
    	if(collision.gameObject.name == "Plane"){
    		if(Input.GetKeyDown("space")){
        	this.rigidbody.velocity = new Vector3(0, 10, 0 );
        	}
    	}
    }
    */
}
