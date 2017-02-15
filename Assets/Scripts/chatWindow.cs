using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chatWindow : MonoBehaviour {
	public Text bodyText;
	public Text speakerText;
	public Image leftPortrait;
	public Image rightPortrait;
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
			if (nextDialogue.StartsWith ("#speaker")) {
				string[] commandElements = nextDialogue.Split (':');
				string speakerName = commandElements [1];
				speakerText.text = speakerName + ":";
				dialogueIndex++;
				advanceText ();
			} else if (nextDialogue.StartsWith ("#leftPortrait")) {
				string[] commandElements = nextDialogue.Split (':');
				string leftPortraitName = commandElements [1];
				Sprite leftPortraitSprite = Resources.Load<Sprite> (leftPortraitName);
				leftPortrait.sprite = leftPortraitSprite;
				dialogueIndex++;
				advanceText ();
			}
			else {
				bodyText.text = nextDialogue;
				dialogueIndex++;
			}
		
		}
	}




}