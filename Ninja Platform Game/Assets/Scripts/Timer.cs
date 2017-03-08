using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public int minutes;
	public float seconds;
	public Text gameTimer;

	// Use this for initialization
	void Start () {

		gameTimer = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		seconds = Time.timeSinceLevelLoad;

		gameTimer.text = seconds.ToString();
	}
}
