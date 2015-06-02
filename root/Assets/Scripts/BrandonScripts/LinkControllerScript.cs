using UnityEngine;
using System.Collections;

//not responsible for causeing the character to animate or tell it what state it is in
//script is just here for updating parameters

public class LinkControllerScript : MonoBehaviour {
	public float maxSpeed = 10f;
	bool facingRight = true;
	Rigidbody2D myBody;

	Animator anim;

	//used for ground
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask WhatisGround;
	public float jumpForce = 700;
	//
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myBody = GetComponent<Rigidbody2D>();
	
	}
	
	// FixedUpdate is called once per fixed frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, WhatisGround);
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", myBody.velocity.y);


		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		myBody.velocity = new Vector2 (move * maxSpeed, myBody.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	
	}

	void Update()
	{
		if (grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetBool("Ground", false);
			myBody.AddForce(new Vector2(0, jumpForce));
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

