using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class botton : MonoBehaviour {

	public GameObject loadingPanel;
	public Slider slider;

	public void LoadScene(int sceneIndex){
		StartCoroutine (LoadAsyncLevel (sceneIndex));
	}

	IEnumerator LoadAsyncLevel(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		loadingPanel.SetActive (true);
		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / 0.9f);
			Debug.Log (progress);
			slider.value = progress;
			yield return null;
		}
	}
}
