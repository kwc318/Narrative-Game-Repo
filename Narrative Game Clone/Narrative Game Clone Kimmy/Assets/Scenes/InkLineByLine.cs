using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;


public class InkLineByLine : MonoBehaviour {

	[SerializeField]
	private TextAsset inkJSONAsset;
	private Story story;
	
	// Use this for initialization
	void Start () {
		story = new Story (inkJSONAsset.text);

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!Input.anyKeyDown) return;
		
		
		
		if (!story.canContinue) return;

		var text = story.Continue();
		var choiceText = "";

		if (story.currentChoices.Count > 0) ;
	}
}
