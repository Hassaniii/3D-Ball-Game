using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public float Force = 1;
    private void FixedUpdate()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)

            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * Force);

        if (vertical < 0)

        { this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * Force); }

        if (horizontal > 0)

        { this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * Force); }
        

        if (horizontal < 0)

        { this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * Force); }
    }


    public void OnCollisionEnter()
    {
        this.GetComponent<AudioSource>().Play();
    }

















}
