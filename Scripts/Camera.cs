using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour {

	public Rigidbody2D target;
	Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = transform.position - target.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if (offset.x > 1) {
			Start ();
		} else {

			transform.position = target.transform.position + offset;
		}
		
	}
}
