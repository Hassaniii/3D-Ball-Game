using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ball = GameObject.Find("Ball");

        Vector3 ballposition = ball.transform.position;

        this.gameObject.transform.position = new Vector3(ballposition.x,2.135f+ ballposition.y , +2.113f +  ballposition.z+ 4.145f);
		
	}
}
