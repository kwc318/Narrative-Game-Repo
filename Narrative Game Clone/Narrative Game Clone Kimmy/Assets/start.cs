using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

	public GameObject fade;
	public bool on;
	public float timer;
	public AudioSource begin;

	
	// Use this for initialization
	void Start ()
	{

		on = false;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (on == true)
		{
			fading();
		}


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
		//SceneManager.LoadScene("Kimmy");
		fade.GetComponent<Animator>().Play("Fadeout");
		on = true;
		begin.Play();
	}

	void fading()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			SceneManager.LoadScene("Kimmy");
		}
	}
	
}
