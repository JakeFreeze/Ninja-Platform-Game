using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public bool targetCollision;
	public LayerMask layer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (targetCollision) {
			Application.LoadLevel ("Lose");
		}
	}

	void OnCollisionEnter2D(Collision2D collision){

		if (Physics2D.Raycast (transform.position, transform.right, .4f , layer) || Physics2D.Raycast (transform.position, -transform.right, .4f , layer) || Physics2D.Raycast (transform.position, transform.up, .4f , layer))
			targetCollision = true;
		else
			targetCollision = false;

	}
}
