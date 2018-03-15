using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {
	public Renderer rend;
	public Shader originalshade;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.material.shader=Shader.Find("Shader");
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.shader = originalshade;
		if (Spectrum2.changecolor == 1) {
			rend.material.SetColor ("_BaseColor", Color.green);
			rend.material.SetColor ("_TargetColor", Color.yellow);
		} else {
			rend.material.SetColor ("_BaseColor", Color.red);
			rend.material.SetColor ("_TargetColor", Color.blue);
		}

		rend.material.SetFloat("_BasePos",transform.position.y -transform.localScale.y);
		rend.material.SetFloat("_TargetPos",transform.position.y +transform.localScale.y);
	}
}
