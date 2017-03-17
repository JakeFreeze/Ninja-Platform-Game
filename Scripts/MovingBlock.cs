using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

	public float moveSpeed;
	public float timedMove;
	int x;

	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x++;
		if (x <= timedMove) {
			transform.Translate (-Vector2.up * moveSpeed);

		} else if (x < timedMove + timedMove) {

			transform.Translate (Vector2.up * moveSpeed);

		} else if(x >= timedMove + timedMove){

			x = 0;
		}

	}
}
