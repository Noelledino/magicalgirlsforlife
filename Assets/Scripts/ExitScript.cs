﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {

	//public transform scene;
	//doesn't actually work like that

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("z"))
			Application.LoadLevel ("sceneBedroom");

	}
}