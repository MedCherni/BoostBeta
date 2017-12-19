using UnityEngine;
using System.Collections;


public class CamDep : MonoBehaviour {
	private GameObject left;
	private GameObject ice;
	private GameObject right;
	public GameObject around;
	public GameObject player;       //Public variable to store a reference to the player game object
	private float OrbitSpeed = 3.9f;
	private Touch touch;


	private Vector3 offset;         //Private variable to store the offset distance between the player and camera
	// Use this for initialization
	void Start () {
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		offset = transform.position - player.transform.position ;
		left = GameObject.Find ("Cube1");
		left = GameObject.Find ("Cube2");
		ice = GameObject.FindGameObjectWithTag ("Cube (5)");
		around.transform.position = new Vector3 (GameObject.FindGameObjectWithTag ("up").transform.position.y+5000f,
			(GameObject.FindGameObjectWithTag ("up").transform.position.y +GameObject.FindGameObjectWithTag ("down").transform.position.y)/2,
			(GameObject.FindGameObjectWithTag ("left").transform.position.z +GameObject.FindGameObjectWithTag ("right").transform.position.z)/2 );
	
		//ice.GetComponent<Collider> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.RotateAround (transform.position, new Vector3 (-1, 0, 0), 1.5f);
		touch = Input.GetTouch(0);
		float x = -7.5f + 16 *touch.position.x / Screen.width;
		float y = -4.5f + 10 *touch.position.y / Screen.height;

		left.transform.position = new Vector3 (x,y,0);
	}
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = player.transform.position + offset*Time.deltaTime;

		//player.transform.Translate(0, 0, -Input.acceleration.x/3);
		//transform.Translate(0, 0, -Input.acceleration.x/3);
		//player.transform.Translate(0,Input.acceleration.y/3, 0);
		//transform.Translate(0,Input.acceleration.y/3, 0);


		if (Input.touchCount > 0) {
			if (Input.touchCount == 1) {
				if (Input.GetTouch (0).position.x > Screen.width / 2) {
					player.transform.RotateAround (around.transform.position, new Vector3 (1, 0, 0), OrbitSpeed);
					player.transform.Rotate (OrbitSpeed * new Vector3 (1, 0, 0), Space.Self);
					transform.RotateAround (around.transform.position, new Vector3 (1, 0, 0), OrbitSpeed);
					//transform.Rotate (OrbitSpeed * new Vector3 (0, 0, 1), Space.Self);
				}
					
				
				
				//transform.Rotate (new Vector3 (0, 0, 1), Space.Self);
			else  {
					player.transform.RotateAround (around.transform.position, new Vector3 (-1, 0, 0), OrbitSpeed);
					//player.transform.Rotate (new Vector3 (OrbitSpeed * -1, 0, 0), Space.Self);
					transform.RotateAround (around.transform.position, new Vector3 (-1, 0, 0), OrbitSpeed);
					transform.Rotate (new Vector3 (OrbitSpeed * 0, 0, -1), Space.Self);
				}
					//transform.Rotate (new Vector3 (0, 0, -1), Space.Self);
				} 
			} else {
				if (Input.acceleration.y > 0 || Input.acceleration.x > 0) {
					//player.transform.Rotate (OrbitSpeed * new Vector3 (1, 0, 0), Space.Self);
				//player.transform.Rotate (OrbitSpeed * new Vector3 (1, 0, 0), Space.Self);
				} else {
				if (Input.acceleration.y > 0 || Input.acceleration.x > 0) {
					//player.transform.Rotate (OrbitSpeed * new Vector3 (1, 0, 0), Space.Self);
					//player.transform.position= player.transform.position + new Vector3(0,0,0.5f);
				} else {
					//player.transform.Rotate (new Vector3 (OrbitSpeed * -1, 0, 0), Space.Self);
					//player.transform.position = player.transform.position + new Vector3(0,0,-0.5f);
				}
					//player.transform.Rotate (new Vector3 (OrbitSpeed * -1, 0, 0), Space.Self);
				}
			}
		}

}
