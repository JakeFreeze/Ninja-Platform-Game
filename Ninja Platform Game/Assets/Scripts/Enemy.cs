using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public bool OnHead;
	public float hitDistance;
	public LayerMask layer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (OnHead)
			Destroy (gameObject);

	}

	void OnCollisionEnter2D(Collision2D collision){

		if (Physics2D.Raycast (transform.position, transform.up, hitDistance, layer))
			OnHead = true;
		else
			OnHead = false;

	}
}
