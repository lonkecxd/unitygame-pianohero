using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoMover : MonoBehaviour {
    public float speed=3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //print(Vector3.forward);
        transform.Translate(Vector3.forward*speed*Time.deltaTime,Space.Self);
	}
}
