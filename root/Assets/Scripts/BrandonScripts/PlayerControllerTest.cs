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

	void Start ()
	{
		myBody = GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;
		//_anim.SetBool ("idle", true);
	}
	
	
	void FixedUpdate ()
	{

		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);

		float move = Input.GetAxis ("Horizontal");
		//move (Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat("Speed", move);

		
		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
		if(Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
		{
			anim.SetTrigger (jumpHash);
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			
			this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
		}

		if (Input.GetKeyDown (KeyCode.A)) 
		{

			this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
		}
	}
	/*
	void move(float horizontalInput)
	{
		if (!canMoveInAir && !isGrounded)
			return;
		
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizontalInput * speed;
		myBody.velocity = moveVel;
	}
	*/
	public void Jump()
	{
		if(isGrounded)
			myBody.velocity += jumpVelocity * Vector2.up;
	}
}