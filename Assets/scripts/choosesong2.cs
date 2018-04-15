using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class choosesong2 : MonoBehaviour {
	
	public GameObject song;
	public GameObject songmenu;
	public GameObject bottommenu;
	public AudioSource music;
	public Camera mycamera;

	public GameObject cubes;
	public GameObject pa;
	public GameObject pb;
	public GameObject pc;

	// Use this for initialization
	void Start () {
		//mysong = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void chooseSong(){
		//border.songname = song.name;
		//border.score = 0;

		Datacontroller.instance.currentSong = new Songdata (song.name);
		song = Instantiate (song, new Vector3 (0, -67, 0), Quaternion.identity);
		song.SetActive (true);

		music.gameObject.SetActive (true);
		music.Play ();
	}

	public void exitMenu(){
		songmenu.SetActive (false);
		bottommenu.SetActive (false);
		mycamera.gameObject.SetActive (true);
		cubes.SetActive (true);
		if (Datacontroller.instance.particles [0])
			pa.SetActive (true);
		if (Datacontroller.instance.particles [1])
			pb.SetActive (true);
		if (Datacontroller.instance.particles [2])
			pc.SetActive(true);
	}
}
