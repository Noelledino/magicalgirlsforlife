﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScene : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)) {
			SceneManager.LoadScene("sceneHub");
		}
	}
}