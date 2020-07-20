using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycreator : MonoBehaviour {

    // Use this for initialization
    public GameObject prefab;
    public int Count;
	void Start () {
        for (int i = 0; i < this.Count; i++)
        {
            GameObject newgameObject = (GameObject)GameObject.Instantiate(prefab);
            newgameObject.transform.position = new Vector3(0,1,-9);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
