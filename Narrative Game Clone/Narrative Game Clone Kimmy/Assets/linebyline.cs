using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Ink.Runtime;
using TMPro;
using UnityEngine.Internal.Experimental.UIElements;
using EZCameraShake;

public class linebyline : MonoBehaviour
{
	public GameObject background;
	public GameObject bg2;
	public GameObject bg3;
	public Sprite krish;
	public Sprite kimmyh;
	public Sprite map;
	public Sprite dash;
	public Sprite nothing;
	public Sprite kris;
	public Sprite kim;
	public Sprite kourtney;
	public Sprite khloe;
	public Sprite kylie;
	public Sprite rob;
	public AudioSource ksound;
	public AudioSource eme;
	public AudioSource what;
	public AudioSource thanks;
	public AudioSource hey;
	public AudioSource yeah;

	
	[SerializeField] private TextAsset _inkJsonAsset;
	[SerializeField] private Story _story;
	
	[SerializeField]
	private Text textPrefab;

	[SerializeField] private TextMeshProUGUI text;
	[SerializeField]
	private Button buttonPrefab;

	
	[SerializeField]
	private Canvas canvas;
	[SerializeField]
	private Canvas canvaschoices;

	private void Start()
	{
		_story = new Story(_inkJsonAsset.text);
		RemoveChildren();
		if (!_story.canContinue) return;
		var text = _story.Continue();
		CreateContentView(text);
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
		//CreateContentView(text);
	}

	private void Update()
	{
		RefreshView();
		//CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
	}

	void RefreshView(){
		
		if (!Input.anyKeyDown) return;
		//CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);

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
		
		CreateContentView(text);

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
		//CreateContentView(text);
		
		foreach (string str in _story.currentTags)
		{

			if (str == "black")
			{
				Debug.Log("black");
				background.GetComponent<SpriteRenderer>().sprite = nothing;
				bg2.GetComponent<SpriteRenderer>().sprite = nothing;
				bg3.GetComponent<SpriteRenderer>().sprite = nothing;
			}
		}
		
		foreach (string str in _story.currentTags)
		{
			Debug.Log(str);
			if (str == "mom")
			{
				Debug.Log("mom");
				background.GetComponent<SpriteRenderer>().sprite = kris;
				//CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
			
			Debug.Log(str);
			if (str == "1")
			{
				Debug.Log("wh");
				bg3.GetComponent<SpriteRenderer>().sprite = krish;
			}

			if (str == "Dana")
			{
				Debug.Log("Dana");
				bg2.GetComponent<SpriteRenderer>().sprite = kourtney;
			}

		}

		foreach (string str in _story.currentTags)
		{

			if (str == "Kimmy")
			{
				Debug.Log("yes");
				bg2.GetComponent<SpriteRenderer>().sprite = kim;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Danal")
			{
				Debug.Log("Danal");
				background.GetComponent<SpriteRenderer>().sprite = kourtney;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "2")
			{
				Debug.Log("2");
				bg3.GetComponent<SpriteRenderer>().sprite = kimmyh;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Kimmyl")
			{
				Debug.Log("Kimmyl");
				background.GetComponent<SpriteRenderer>().sprite = kim;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "kmom")
			{
				Debug.Log("kmom");
				bg2.GetComponent<SpriteRenderer>().sprite = khloe;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "maps")
			{
				Debug.Log("maps");
				bg3.GetComponent<SpriteRenderer>().sprite = map;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Donna")
			{
				Debug.Log("Donna");
				bg2.GetComponent<SpriteRenderer>().sprite = kylie;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Rob")
			{
				Debug.Log("Rob");
				bg2.GetComponent<SpriteRenderer>().sprite = rob;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "store")
			{
				Debug.Log("store");
				bg3.GetComponent<SpriteRenderer>().sprite = dash;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "ksound")
			{
				Debug.Log("ksound");
				ksound.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "eme")
			{
				Debug.Log("eme");
				eme.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "what")
			{
				Debug.Log("what");
				what.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "thanks")
			{
				Debug.Log("thanks");
				thanks.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "hey")
			{
				Debug.Log("hey");
				hey.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "yeah")
			{
				Debug.Log("yeah");
				yeah.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
	}
	
	void OnClickChoiceButton(Choice choice)
	{
		_story.ChooseChoiceIndex(choice.index);
		RemoveChildren();
		var text = _story.Continue();
		var choiceText = "";
		CreateContentView(text);
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
		
		foreach (string str in _story.currentTags)
		{

			if (str == "black")
			{
				Debug.Log("black");
				background.GetComponent<SpriteRenderer>().sprite = nothing;
				bg2.GetComponent<SpriteRenderer>().sprite = nothing;
				bg3.GetComponent<SpriteRenderer>().sprite = nothing;
			}
		}
		
		foreach (string str in _story.currentTags)
		{
			Debug.Log(str);
			if (str == "mom")
			{
				Debug.Log("mom");
				background.GetComponent<SpriteRenderer>().sprite = kris;
			}
			
			Debug.Log(str);
			if (str == "1")
			{
				Debug.Log("wh");
				bg3.GetComponent<SpriteRenderer>().sprite = krish;
			}

			if (str == "Dana")
			{
				Debug.Log("Dana");
				bg2.GetComponent<SpriteRenderer>().sprite = kourtney;
			}

		}

		foreach (string str in _story.currentTags)
		{

			if (str == "Kimmy")
			{
				Debug.Log("yes");
				bg2.GetComponent<SpriteRenderer>().sprite = kim;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Danal")
			{
				Debug.Log("Danal");
				background.GetComponent<SpriteRenderer>().sprite = kourtney;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "2")
			{
				Debug.Log("2");
				bg3.GetComponent<SpriteRenderer>().sprite = kimmyh;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Kimmyl")
			{
				Debug.Log("Kimmyl");
				background.GetComponent<SpriteRenderer>().sprite = kim;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "kmom")
			{
				Debug.Log("kmom");
				bg2.GetComponent<SpriteRenderer>().sprite = khloe;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "maps")
			{
				Debug.Log("maps");
				bg3.GetComponent<SpriteRenderer>().sprite = map;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Donna")
			{
				Debug.Log("Donna");
				bg2.GetComponent<SpriteRenderer>().sprite = kylie;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "Rob")
			{
				Debug.Log("Rob");
				bg2.GetComponent<SpriteRenderer>().sprite = rob;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "store")
			{
				Debug.Log("store");
				bg3.GetComponent<SpriteRenderer>().sprite = dash;
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "ksound")
			{
				Debug.Log("ksound");
				ksound.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "eme")
			{
				Debug.Log("eme");
				eme.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "what")
			{
				Debug.Log("what");
				what.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "thanks")
			{
				Debug.Log("thanks");
				thanks.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "hey")
			{
				Debug.Log("hey");
				hey.Play();
			}
		}
		
		foreach (string str in _story.currentTags)
		{

			if (str == "yeah")
			{
				Debug.Log("yeah");
				yeah.Play();
				CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
			}
		}
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
		int childCountc = canvaschoices.transform.childCount;
		for (int i = childCountc - 1; i >= 0; --i) {
			GameObject.Destroy (canvaschoices.transform.GetChild (i).gameObject);
		}
	}
	
	Button CreateChoiceView (string text) {
		// Creates the button from a prefab
		Button choice = Instantiate (buttonPrefab) as Button;
		choice.transform.SetParent (canvaschoices.transform, false);
		
		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text> ();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent <HorizontalLayoutGroup> ();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}
}