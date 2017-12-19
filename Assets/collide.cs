using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = GameObject.Find ("Main Camera").transform.position;   

	}
	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.name == "Cube (5)")
		{ 
			Application.LoadLevel(1);

		} 

	}
}
