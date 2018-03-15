using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexController : MonoBehaviour {
    public int score=0;
    public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        text.GetComponent<UnityEngine.UI.Text>().text = "score: " + score.ToString();
	}
   public  void SPlus(int s)
    {
        score += s;
    }
}
