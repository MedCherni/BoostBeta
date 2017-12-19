using UnityEngine;
using System.Collections;

public class transaction : MonoBehaviour {
	private  float timer=0f;
	bool start = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {

			timer += 0.1f;
		

		if ((int)timer == 5) {
			Application.LoadLevel (1);
		}
	
	}
}
