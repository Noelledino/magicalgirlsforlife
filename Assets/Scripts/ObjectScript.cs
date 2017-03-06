using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
	private Renderer rend;
	public GameObject ObjectText;

	void  Start ()
	{
		rend = GetComponent<Renderer> ();
	}

	void OnMouseEnter ()
	{
		rend.material.color -= new Color (10F, 10, 10) * Time.deltaTime;

	}

	void OnMouseDown ()
	{ 
	}

	void OnMouseExit ()
	{
		rend.material.color = Color.white;

	}

	void Update() 
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			if (GetComponent<Collider2D> ().OverlapPoint (mousePos)) {
				Debug.Log ("An object has been clicked.");
				ObjectText.SetActive (true);
			}
		}
	}
}