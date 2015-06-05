using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//float translate = Input.GetAxis("Horizontal");
		
		
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-1f*Time.deltaTime,0.0f,0.0f);
		} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (1f*Time.deltaTime,0.0f,0.0f);
		} else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(0.0f,0.0f, 1f*Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0.0f,0.0f,-1f* Time.deltaTime);
			
		}
	}
}
