using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class camove : MonoBehaviour {

	public float vitesse;
	private Rigidbody rigidBody;
	public GameObject next;
	public GameObject previous;

	public GameObject map;
	private int plus = 10;
	private float initPos;
	private GameObject end;
	private Vector3 start;
	private Vector3 stop;
	private Vector3 posMap ;
	public Text score;
	private float count=0f;
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
		posMap = new Vector3 (30, 0, 0);


	}

	// Update is called once per frame
	void Update () {
		count+=0.02f ;
	/*	foreach(Collider c in GetComponents<Collider> ()) {
			if (c != GameObject.Find ("Cube (5)").GetComponent<Collider>()&&c != GameObject.Find ("me").GetComponent<Collider>()) {
				c.enabled = false;
			}
		}*/
		/*foreach(Collider c in map.GetComponents<Collider> () ) {
			if(map != null)
				c.enabled = false;
		}*/

		float deplacement = vitesse * Time.deltaTime ;
		transform.Translate (deplacement * new Vector3(1,0,0), Space.Self);
	score.text = "Score : " +(int) count;

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





	}

}
