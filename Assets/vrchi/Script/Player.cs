using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private Rigidbody rb;
	
	private float speed = 1.5f;
	public bool facingRight;
	public bool facingForward;
	public bool facingLeft;
	public bool facingBack;
	public bool walking = false;
	// Use this for initialization
	void Start () {
		walking = false;
	}
	
	// Update is called once per frame
	void Update () {
		float translate = Input.GetAxis("Horizontal");
		float translateVert = Input.GetAxis("Vertical");
		
		
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			facingLeft = true;
			facingRight = false;
			facingForward = false;
			facingBack = false;
			walking = true;
			transform.right = new Vector3 (1, 0, 0);
			GetComponent<Animation> ().CrossFade ("Run_chr"); 
			Debug.Log ("Left");
		} else if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
			facingLeft = false;
			facingRight = true;
			facingForward = false;
			facingBack = false;
			walking = true;
			transform.right = new Vector3 (-1, 0, 0);
			GetComponent<Animation> ().CrossFade ("Run_chr");
			Debug.Log ("Right");
		} else if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
			facingLeft = false;
			facingRight = false;
			facingForward = true;
			facingBack = false;
			walking = true;
			transform.right = new Vector3 (0, 0, -1);
			GetComponent<Animation> ().CrossFade ("Run_chr");
			Debug.Log ("Up");
		} else if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			facingLeft = false;
			facingRight = false;
			facingForward = false;
			facingBack = true;
			walking = true;
			transform.right = new Vector3 (0, 0, 1);
			GetComponent<Animation> ().CrossFade ("Run_chr");
			Debug.Log ("Down");
			
		} else {
			if (
				(!Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.LeftArrow)) &&
				(!Input.GetKey (KeyCode.D) && !Input.GetKey (KeyCode.RightArrow)) &&
				(!Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.UpArrow)) &&
				(!Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.DownArrow))
				) {
				GetComponent<Animation> ().CrossFade ("Idle_chr");
			}
		}
		if(facingLeft){
			transform.Translate (Vector3.right * translate * 1.25f * Time.deltaTime);
			
		}
		if(facingRight){
			transform.Translate (Vector3.right * -translate * 1.25f * Time.deltaTime);
			
		}
		if(facingForward){
			transform.Translate(Vector3.left * translateVert * 1.25f * Time.deltaTime);
			
		}
		if(facingBack){
			transform.Translate (-Vector3.left * translateVert * 1.25f * Time.deltaTime);
			
		}
	}
}
