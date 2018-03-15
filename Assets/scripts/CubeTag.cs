using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTag : MonoBehaviour {
    public int tag=0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.SetFloat("_BasePos", -transform.localScale.y);
        GetComponent<Renderer>().material.SetFloat("_TargetPos", transform.localScale.y);

    }
}
