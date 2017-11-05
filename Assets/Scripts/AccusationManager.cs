using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccusationManager : MonoBehaviour {

	public Button accuseButton;

	// Use this for initialization
	void Start () {
		// Have this button be invisible at the beginning of the scene
		accuseButton.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
		{
			// Toggle AccuseButton visibility
			accuseButton.gameObject.SetActive (!accuseButton.gameObject.activeInHierarchy);
		}
		
	}
}
