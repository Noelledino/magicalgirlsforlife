using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour
{
	private Renderer rend;
	public GameObject ObjectDialogue;


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
		Debug.Log ("An object has been clicked.");
		ObjectDialogue.SetActive (true);
	}

	void OnMouseExit ()
	{
		rend.material.color = Color.white;

	}

}