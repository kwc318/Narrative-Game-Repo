using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour {
	
	public Animator fadeout;

	// Use this for initialization
	void Start ()
	{

		fadeout = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			fadeout.Play("Fadeout");
			Debug.Log("hudns");
		}
		
	}
	
}
