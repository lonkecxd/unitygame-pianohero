using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class toggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void particleOn(){
		if(gameObject.tag=="a")
		  Datacontroller.instance.particles[0] = GetComponent<Toggle> ().isOn;
		else if(gameObject.tag=="b")
			Datacontroller.instance.particles[1] = GetComponent<Toggle> ().isOn;
		else 
			Datacontroller.instance.particles[2] = GetComponent<Toggle> ().isOn;
	}

}
