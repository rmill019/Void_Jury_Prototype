﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	Vector3 mousePosition;
	RaycastHit hit;
	Ray ray;

	void Start() {
		//Initialize ray
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

	}

	void Update() {
		//Update ray
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		mousePosition = Input.mousePosition;

		//The raycast works but in scene view it points towards canvas
		Debug.DrawRay (transform.position, mousePosition, Color.green);

		if (Input.GetMouseButtonDown(0)) {
			if (Physics.Raycast (ray, out hit, 100.0f)) {
				Debug.Log ("You have selected the " + hit.transform.name);

			}
		}
	}
} 