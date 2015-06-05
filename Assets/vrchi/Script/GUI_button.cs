using UnityEngine;
using System.Collections;

public class GUI_button : MonoBehaviour {

	// Use this for initialization
	private void Start () {
	
	}
	
	// Update is called once per frame
	private void Update () {
	
	}
	private void OnGUI () {
		if (GUI.Button (new Rect ((Screen.width/2)-100, (Screen.height/2), 200, 30), "New Game")) {
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (new Rect ((Screen.width/2)-100, (Screen.height/2)+50, 200, 30), "Quit")) {
			Application.Quit();
		}
	}
}
