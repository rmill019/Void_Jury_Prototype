using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crew_Pilot : Crew {

	//Canvas GameObjects for chatbox
	public GameObject TextBox;
	public GameObject Sprite;
	// Use this for initialization
	void Start () {
		// Set the visibility of the sprite and textbox to false
		TextBox.SetActive (false);
		Sprite.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		DeadCheck ();
	}

	/*void OnMouseDown() {
		Judgement ();
	}*/

	void OnMouseDown()
	{
		// Activate the sprite and corresponding TextBox to be visible when the crew member is clicked on.
		print ("Pilot Selected");
		Sprite.SetActive (true);
		TextBox.SetActive (true);
	}
}
