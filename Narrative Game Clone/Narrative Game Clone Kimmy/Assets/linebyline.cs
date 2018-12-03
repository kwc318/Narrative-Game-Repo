using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Ink.Runtime;

public class linebyline : MonoBehaviour
{
	public GameObject background;
	public GameObject bg2;
	public GameObject bg3;
	public Sprite wh;
	public Sprite kris;
	public Sprite kim;
	public Sprite kourtney;
	
	[SerializeField] private TextAsset _inkJsonAsset;
	[SerializeField] private Story _story;
	
	[SerializeField]
	private Text textPrefab;
	[SerializeField]
	private Button buttonPrefab;
	
	
	[SerializeField]
	private Canvas canvas;

	private void Start()
	{
		_story = new Story(_inkJsonAsset.text);
		RemoveChildren();
		if (!_story.canContinue) return;
		var text = _story.Continue();
		if (_story.currentChoices.Count > 0)
		{
			for (var i = 0; i < _story.currentChoices.Count; i++) {
				Choice choice = _story.currentChoices [i];
				Button button = CreateChoiceView (choice.text.Trim ());
				// Tell the button what to do when we press it
				button.onClick.AddListener (delegate {
					OnClickChoiceButton (choice);
				});
			}
		}
		CreateContentView(text);
	}

	private void Update()
	{
		RefreshView();
	}

	void RefreshView(){
		
		if (!Input.anyKeyDown) return;
		//RemoveChildren();
		
		if (_story.currentChoices.Count > 0)
		{
			for (var i = 0; i < _story.currentChoices.Count; i++)
			{
				//KeyCode.Alpha1 = 49
				// "(KeyCode)49" casts 49 to the KeyCode enum
				if (Input.GetKeyDown((KeyCode) 49 + i))
				{
					_story.ChooseChoiceIndex(i);
					//RemoveChildren();
				}
			}
		}

		if (!_story.canContinue) return;

		var text = _story.Continue();
		//var choiceText = "";
		RemoveChildren();

		if (_story.currentChoices.Count > 0)
		{
			for (var i = 0; i < _story.currentChoices.Count; i++) {
				Choice choice = _story.currentChoices [i];
				Button button = CreateChoiceView (choice.text.Trim ());
				// Tell the button what to do when we press it
				button.onClick.AddListener (delegate {
					OnClickChoiceButton (choice);
				});
			}
		}

		//Debug.LogFormat("{0} with choices:\n {1}", text, choiceText);
		CreateContentView(text);
		
		foreach (string str in _story.currentTags)
		{
			Debug.Log(str);
			if (str == "mom")
			{
				Debug.Log("works");
				bg3.GetComponent<SpriteRenderer>().sprite = wh;
				background.GetComponent<SpriteRenderer>().sprite = kris;
			}

			if (str == "Dana")
			{
				Debug.Log("works");
				bg2.GetComponent<SpriteRenderer>().sprite = kourtney;
			}

			else //(str == "Kimmy")
			{
				Debug.Log("works");
				background.GetComponent<SpriteRenderer>().sprite = kim;
			}
		}
	}
	
	void OnClickChoiceButton(Choice choice)
	{
		_story.ChooseChoiceIndex(choice.index);
		RemoveChildren();
		var text = _story.Continue();
		var choiceText = "";
		if (_story.currentChoices.Count > 0)
		{
			for (var i = 0; i < _story.currentChoices.Count; i++) {
				Choice choices = _story.currentChoices [i];
				Button button = CreateChoiceView (choices.text.Trim ());
				// Tell the button what to do when we press it
				button.onClick.AddListener (delegate {
					OnClickChoiceButton (choices);
				});
			}
		}
		CreateContentView(text);
		
		//RefreshView();
		
	}

	void CreateContentView(string text)
	{
		Text storyText = Instantiate(textPrefab) as Text;
		storyText.text = text;
		storyText.transform.SetParent(canvas.transform, false);
	}
	
	void RemoveChildren () {
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i) {
			GameObject.Destroy (canvas.transform.GetChild (i).gameObject);
		}
	}
	
	Button CreateChoiceView (string text) {
		// Creates the button from a prefab
		Button choice = Instantiate (buttonPrefab) as Button;
		choice.transform.SetParent (canvas.transform, false);
		
		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text> ();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent <HorizontalLayoutGroup> ();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}
}