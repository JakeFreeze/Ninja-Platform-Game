using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public int minutes;
	public float startSeconds;
	public float endSeconds;
	public Text gameTimer;
	bool timeIt;

	// Use this for initialization
	void Start () {

		gameTimer = GetComponent<Text> ();
		startSeconds = Time.timeSinceLevelLoad;
		timeIt = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float currentSeconds = Time.timeSinceLevelLoad - startSeconds;
		if (timeIt == true) {
			gameTimer.text = currentSeconds.ToString ();
		}
	}

	public void EndTimer(){

		endSeconds = Time.timeSinceLevelLoad;

		string seconds = (endSeconds - startSeconds).ToString ();

		gameTimer.text = seconds;

		timeIt = false;

	}

}
