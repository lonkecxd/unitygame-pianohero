using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {
	public Renderer rend;
	public Shader originalshade;
	float seconds = 0.0f;
	float secondsPerLerp=0.2f;
	float cur = 0f;
	float inc = 0f;
	float dec = 1.0f;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.material.shader=Shader.Find("Shader");
		seconds = secondsPerLerp;
	}
	
	// Update is called once per frame
	void Update () {
		if(rend.material.shader != originalshade)
			rend.material.shader = originalshade;
		
		if (seconds >= 1f){
			seconds = 0f;
			//cur= rend.material.GetColor ("_BaseColor").r;
			cur= (inc+dec)/2.0f;
		}
		seconds += Time.deltaTime;
		inc = Mathf.Lerp (cur, 1f, seconds);
		dec = Mathf.Lerp (cur, 0f, seconds);

		if (Spectrum2.changecolor == 1) {
			rend.material.SetColor ("_BaseColor",new Color(inc,inc,dec));
			rend.material.SetColor ("_TargetColor",new Color(inc,0.5f,dec) );
		} else if(Spectrum2.changecolor == 0){
			rend.material.SetColor ("_BaseColor", new Color(dec,0.5f,inc));
			rend.material.SetColor ("_TargetColor", new Color(dec,inc,inc));
		}

		//rend.material.SetFloat("_BasePos",transform.position.y -transform.localScale.y);
		//rend.material.SetFloat("_TargetPos",transform.position.y +transform.localScale.y);
	}

}
