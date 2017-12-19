using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
			/*if (Input.touchCount > 0) {
				if (Input.touchCount == 1) {
					if (Input.GetTouch (0).position.x < Screen.width / 2) {
						Application.Quit ();
					}


					else  {
						Application.LoadLevel(0);
					}

				} 
			}*/




	
	}
	public void Restart(){
		Application.LoadLevel(0);
	}
	public void QuitGame(){
		Application.Quit ();
	}
}
