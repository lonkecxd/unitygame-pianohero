using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user : MonoBehaviour {

	public InputField inputName;

	private Text me;
	// Use this for initialization
	void Start () {
		me = GetComponent<Text> ();
		me.text = Datacontroller.instance.username;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void SaveName(){
		me.text = inputName.text;
		Datacontroller.instance.SaveUsername (inputName.text);
	}
}
