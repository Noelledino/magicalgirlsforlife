using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour
{
	private Renderer rend;


	void  Start ()
	{
		rend = GetComponent<Renderer> ();
	}

	void OnMouseEnter ()
	{
		rend.material.color -= new Color (10F, 10, 10) * Time.deltaTime;
		AudioSource ourAudio = GetComponent<AudioSource> ();

	}

	void OnMouseDown ()
	{ 
		Debug.Log ("An object has been clicked.");
	}

	void OnMouseExit ()
	{
		rend.material.color = Color.white;

	}

}