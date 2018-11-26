using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseEnter()
	{
		Debug.Log("yes");
		gameObject.GetComponent<Renderer>().material.color = Color.green;
	}

	void OnMouseExit()
	{
		Debug.Log("no");
		gameObject.GetComponent<Renderer>().material.color = Color.white;
	}

	void OnMouseDown()
	{
		Debug.Log("next");
		SceneManager.LoadScene("Kimmy");
	}
	
}
