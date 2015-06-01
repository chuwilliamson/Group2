using UnityEngine;
using System.Collections;

public class PlayerControllerTest : MonoBehaviour 
{
	public float speed = 10, jumpVelocity = 10;
	public LayerMask playerMask;
	public bool canMoveInAir = true;
	Transform myTrans, tagGround;
	Rigidbody2D myBody;
	[SerializeField]
	//private Animator _anim;

	bool isGrounded = false;

	Animator anim;
	int jumpHash = Animator.StringToHash("Jump");
	int runStateHash = Animator.StringToHash("Base Layer.Run");


	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	/*
	//My Original Coding
	void Start ()
	{
		myBody = GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;
		//_anim.SetBool ("idle", true);
	}
	*/
	
	void FixedUpdate ()
	{
		////* My original Code *//// tested and works. Player moves and jumps. No animations except for looped idle
		//isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);
		/*
		Move (Input.GetAxisRaw ("Horizontal"));
		if (Input.GetButtonDown ("Jump"))
			Jump ();
		*/

		/////* Alternate Coding */////
		// Player can't move, but animation are used correctly
		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat("Speed", move);

		////////* Alternate Jumping code + animations *//////////
		 
		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
		if(Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
		{
			anim.SetTrigger (jumpHash);
		}


		////* The Blender *//// work in progress. Trying to player move and use animations.
		//isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);

		//Move (Input.GetAxis ("Horizontal"));
		//anim.SetFloat ("Speed");

		//If key is pressed rotate player 90 or 270 degrees
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
		}

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
		}
	}
	
	//My Original Coding
	void Move(float horizontalInput, float Speed)
	{
		if (!canMoveInAir && !isGrounded)
			return;
		
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizontalInput * speed;
		myBody.velocity = moveVel;
	}
	/*
	//My Original Coding
	public void Jump()
	{
		if(isGrounded)
			myBody.velocity += jumpVelocity * Vector2.up;
	}
	*/
}