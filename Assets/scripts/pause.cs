using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {
	public GameObject continueBtn;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void pauseGame(){
		Time.timeScale=0;
		continueBtn.SetActive (true);
	}
	public void continueGame(){
		Time.timeScale=1;
		continueBtn.SetActive (false);
	}
	public void exitGame(){
		SceneManager.LoadScene (0);
	}
	public void replayGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}
