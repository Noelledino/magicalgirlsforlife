using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScene : MonoBehaviour {

	public AudioClip hover;
	public AudioClip click;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)) {
			SceneManager.LoadScene("sceneHub");
			AudioSource ourAudio = GetComponent<AudioSource> ();
			ourAudio.PlayOneShot (hover);
		}
	}
}