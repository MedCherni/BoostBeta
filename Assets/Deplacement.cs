using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {
	public float vitesse;
	private Rigidbody rigidBody;
	public GameObject next;
	public GameObject previous;

	public GameObject map;
	private int plus = 10;
	private float initPos;
	private float initPosZ;
	private GameObject end;
	private Vector3 start;
	private Vector3 stop;
	private Vector3 posMap ;
	// Use this for initialization
	void Start () {
		previous = null;
		rigidBody = GetComponent<Rigidbody>();
		initPos = GameObject.Find("me").transform.position.x;

		end = GameObject.Find ("end");
		map = GameObject.Find ("hofra");
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);
		posMap = new Vector3 (1, 0, 0);
		start = GameObject.Find ("me").transform.position;


	}
	
	// Update is called once per frame
	void Update () {
	/*	foreach(Collider c in GetComponents<Collider> ()) {
			if (c != GameObject.Find ("Cube (5)").GetComponent<Collider>()&&c != GameObject.Find ("me").GetComponent<Collider>()) {
				c.enabled = false;
			}
		}
		foreach(Collider c in map.GetComponents<Collider> () ) {
			if(map != null)
			c.enabled = false;
		}*/
		
		float deplacement = vitesse * Time.deltaTime ;
		transform.Translate (deplacement * new Vector3(1,0,0), Space.Self);
		//map.transform.Translate (deplacement * new Vector3 (1, 0, 0), Space.Self);
		/*switch (Input.touchCount) {
		case 1:
			transform.Translate (new Vector3 (0, 1, 1), Space.Self);
			break;
		case 2:
			transform.Translate (new Vector3 (0, 2, 0), Space.Self);
			break;
		case 3:
			transform.Translate (new Vector3 (0, 0, 1), Space.Self);
			break;
		case 4:
			transform.Translate (new Vector3 (0, -1, 0), Space.Self);
			break;

		}*/
		if(Input.touchCount >0)
		{    
			// touch on screen
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				//map.transform.Rotate (20*new Vector3 (1, 0, 0));
				//transform.Translate(new Vector3(0,0,-2),Space.Self);

			}


			// release touch/dragging
			if((Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled) )
			{
				//end.transform.Rotate (-20*new Vector3 (1, 0, 0));
			}
		} 
		//previous = map;
		//next = previous;


		  
		if (GameObject.Find ("me").transform.position.x - initPos > 7 ) {
			//map.transform.RotateAround (map.transform.position, new Vector3 (1, 0, 0), 1.5f);
			//posMap = posMap + new Vector3(30,0,0);
			posMap = new Vector3(1,0,0);

			//if(previous != null) Destroy (previous);

			previous = (GameObject)Instantiate(map, new Vector3(map.transform.position.x+plus, map.transform.position.y ,map.transform.position.z) , Quaternion.identity);
			//previous.transform.RotateAround (map.transform.position, new Vector3 (1, 0, 0), 1.5f);
			int rand = Random.Range (1, 12);
			switch (rand)
			{
			case 1:
				previous.transform.Rotate (posMap * 30);
				//previous.transform.RotateAround (start, posMap * 30, 50f); 
				break;
			case 2:
				previous.transform.Rotate ( posMap*60);
				//previous.transform.RotateAround (start, posMap * 60, 50f);
				break;
			case 3:
				previous.transform.Rotate ( posMap*90);
				//previous.transform.RotateAround (start, posMap * 90, 50f);
				break;
			case 4:
				previous.transform.Rotate ( posMap*-30);
				//previous.transform.RotateAround (start, posMap * -30, 50f);
				break;
			case 5:
				previous.transform.Rotate ( posMap*-60);
				//previous.transform.RotateAround (start, posMap * -60, 50f);
				break;
			case 6:
				previous.transform.Rotate ( posMap*-90);
				//previous.transform.RotateAround (start, posMap * -90, 50f);
				break;
			case 7:
				previous.transform.Rotate ( posMap*120);
				//previous.transform.RotateAround (start, posMap * 120, 50f);
				break;
			case 8:
				previous.transform.Rotate ( posMap*-120);
				//previous.transform.RotateAround (start, posMap * -120, 50f);
				break;
			case 9:
				previous.transform.Rotate ( posMap*150);
				//previous.transform.RotateAround (start, posMap * 150, 50f);
				break;
			case 10:
				previous.transform.Rotate ( posMap*180);
				//previous.transform.RotateAround (start, posMap * 180, 50f);
				break;
			case 11:
				previous.transform.Rotate ( posMap*-150);
				//previous.transform.RotateAround (start, posMap * -150, 50f);
				break;
			case 12:
				previous.transform.Rotate ( posMap*-180);
				//previous.transform.RotateAround (start, posMap * -180, 50f);
				break;
			}
			
			//previous.transform.Rotate ( posMap);
			//next.transform.RotateAround (map.transform.position, new Vector3 (1, 0, 0), 1.5f);
			plus += 25;
			initPos = GameObject.Find("me").transform.position.x;
			//map = next;
			//Destroy (previous);
			//end.transform.Translate (8* new Vector3 (1,0,0) , Space.Self);

	
	}

}
	void OnCollisionEnter(Collision collision) {

		//if(collision.gameObject.name == "Cube (5)")
		//{ 
			Application.LoadLevel(2);

		//} 

	}

}