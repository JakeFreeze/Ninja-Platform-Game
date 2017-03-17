using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KendleMovement : MonoBehaviour {

	public float MoveSpeed;
	Rigidbody2D Kendle;
	public float hitDistance;
	public bool isGrounded;
	public bool isOnWall;
	public LayerMask layer;

	// Use this for initialization
	void Start () {

		Kendle = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Kendle.freezeRotation = true;
		checkWalls ();
		if (!isOnWall && isGrounded|| !isGrounded && !isOnWall || isOnWall && isGrounded || isOnWall) {

			if (Input.GetKey ("d"))
				transform.Translate (Vector2.right * MoveSpeed * Time.deltaTime);	
			if (Input.GetKey("a"))
				transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

		}

		if (isOnWall && !isGrounded) {

			Kendle.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

		}else {

			Kendle.constraints = RigidbodyConstraints2D.FreezeRotation;
		
		}
		if(Input.GetKey ("s"))
			Kendle.constraints = RigidbodyConstraints2D.FreezeRotation;



		checkGround ();
		if (isGrounded || !isGrounded && isOnWall) {
			Kendle.gravityScale = 0;
			if (Input.GetKey ("space")) {

				Kendle.velocity =  (Vector2.up * 8);
				Kendle.gravityScale = 1;
				Kendle.constraints = RigidbodyConstraints2D.FreezeRotation;
			}
		} else {

			Kendle.gravityScale = 1;
		}
	}

	public void checkGround(){

		if (Physics2D.Raycast (transform.position, -transform.up, hitDistance, layer))
			isGrounded = true;
		else
			isGrounded = false;
	}

	public void checkWalls(){

		if (Physics2D.Raycast (transform.position, transform.right, .35f , layer) || Physics2D.Raycast (transform.position, -transform.right, .35f , layer))
			isOnWall = true;
		else
			isOnWall = false;

	}
		

}
