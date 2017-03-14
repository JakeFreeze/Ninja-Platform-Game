using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public int minutes;
	public float startSeconds;
	public float endSeconds;
	public Text gameTimer;

	// Use this for initialization
	void Start () {

		gameTimer = GetComponent<Text> ();
		startSeconds = Time.timeSinceLevelLoad;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		gameTimer.text = seconds.ToString();
	}

	public void EndTimer(){

		endSeconds = Time.timeSinceLevelLoad;

		string seconds = (endSeconds - startSeconds).ToString ();

		gameTimer.text = seconds;

	}

}
