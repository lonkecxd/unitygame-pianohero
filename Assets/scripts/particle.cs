﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {
	// Use this for initialization
	void Start () {
		if (Datacontroller.instance.particle) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
