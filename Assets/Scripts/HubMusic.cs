using UnityEngine;
using System.Collections;

public class HubMusic : MonoBehaviour {
	public bool PlayingTitleSong = false;
	bool AudioBegin = false; 
	void Start()
	{
		if (!AudioBegin && !PlayingTitleSong ) {
			GetComponent<AudioSource>().Stop();
			GetComponent<AudioSource>().Play ();

			AudioBegin = true;
			PlayingTitleSong  = true;
		} 
	}
	void Update () {
		if(Application.loadedLevelName == "StartGame")
		{
			GetComponent<AudioSource>().Stop();
			AudioBegin = false;
			PlayingTitleSong  = false;
		}
	}
}
