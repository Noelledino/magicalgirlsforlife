using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catConversation : MonoBehaviour {
	public GameObject DialogueWindow;
	private Renderer rend;
	private bool firstConversation;
	public GameObject Cat;
	public GameObject DialogueWindowNotFirst;

	// Use this for initialization
	void Start () {
		firstConversation = true;
		rend = Cat.GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		if (firstConversation) {
			DialogueWindow.SetActive (true);
			firstConversation =  false;
		}
	}

	void OnMouseEnter ()
	{
		if (!firstConversation) {
			rend.material.color -= new Color (10F, 10, 10) * Time.deltaTime;
		}
	}

	void OnMouseDown ()
	{ 
		if (!firstConversation) {
			Debug.Log ("An object has been clicked.");
			DialogueWindowNotFirst.SetActive (true);
		}
	}

	void OnMouseExit ()
	{
		rend.material.color = Color.white;

	}
}
