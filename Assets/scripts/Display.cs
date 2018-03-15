using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour {

	public GameObject theObject;

	private bool isOn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayIt(){
		if (!isOn) {
			theObject.SetActive (true);
			isOn = true;
		} else {
			theObject.SetActive (false);
			isOn = false;
		}

		
	}

}
