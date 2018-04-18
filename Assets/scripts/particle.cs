using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "a" && Datacontroller.instance.particles [0])
			this.gameObject.SetActive (true);
		else
			this.gameObject.SetActive (false);
	
		if (gameObject.tag == "b" && Datacontroller.instance.particles [1])
			this.gameObject.SetActive (true);
		else
			this.gameObject.SetActive (false);

		if (gameObject.tag == "c" && Datacontroller.instance.particles [2])
			this.gameObject.SetActive (true);
		else
			this.gameObject.SetActive (false);
	}
}
