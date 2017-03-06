using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectText : MonoBehaviour {

	public Text bodyText;
	public TextAsset ourDialogueFile;


	string[] dialogue;
	int dialogueIndex = 0;

	// Use this for initialization
	void Start () {
		string ourFullDialogue = ourDialogueFile.text;
		dialogue = ourFullDialogue.Split ('\n');
		advanceText ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			advanceText ();
		}
	}

	public void activateChatWindow(TextAsset chatFileToUse){
		string ourFullDialogue = ourDialogueFile.text;
		dialogue = ourFullDialogue.Split ('\n');
		advanceText ();
		gameObject.SetActive(true);
	}

	void advanceText() {
		if (dialogueIndex >= dialogue.Length) {
			gameObject.SetActive (false);
		}
			else {
			string nextDialogue = dialogue [dialogueIndex];
				bodyText.text = nextDialogue;
				dialogueIndex++;
			}

		}
	}
	