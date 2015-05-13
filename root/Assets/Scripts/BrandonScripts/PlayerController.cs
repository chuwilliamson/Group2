using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 10, jumpVelocity = 10;
	public LayerMask playerMask;
	public bool canMoveInAir = true;
	Transform myTrans, tagGround;
	Rigidbody2D myBody;
	[SerializeField]
	private Animator _anim;

	bool isGrounded = false;

	void Awake()
	{
		//grab the animator from the gameobject that this script is attached to
		_anim = this.GetComponent<Animator> ();
		
	}
	
	void Start ()
	{
		myBody = GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;
	}

	
	void FixedUpdate ()
	{
		
		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);
		
		Move (Input.GetAxisRaw ("Horizontal"));
		if (Input.GetButtonDown ("Jump"))
		   	Jump ();
		/*
		 * when you press d face right
		 * when you press a face left
		 * when you are not pressing anything idle and face whatever it means to idle
		 * switch(input)
		 * case a: face right break;
		 * case d: face left break;
		 * default: idle face idle break;
		 * just write code that turns him when you press input
		 */
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			
			{
				_anim.SetTrigger ("right");
				this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 200, 0));
			}
			
			Debug.Log("face right");
		}
		/*
		if (Input.GetKeyUp (KeyCode.D)) 
		{
			{
				_anim.SetTrigger ("idle");
			}
			Debug.Log ("Idle");
		}
		*/
		if (Input.GetKeyDown (KeyCode.A))
		{
			
			{
				_anim.SetTrigger ("left");
				this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 360, 0));
			}
			
			Debug.Log("face left");
		}
		/*
		if (Input.GetKeyUp (KeyCode.A)) 
		{
			{
				_anim.SetTrigger ("idle");
			}
			Debug.Log("Idle");
		}
		*/
	}
	
	void Move(float horizonalInput)
	{
		if(!canMoveInAir && !isGrounded)
			return;
		
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizonalInput * speed;
		myBody.velocity = moveVel;
	}

	/*
	void FixedUpdate ()
	{
		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);

		Move(Input.GetAxisRaw("Horizontal"));
		if(Input.GetButtonDown("Jump"))
			Jump();
	
	}
	
	void Move(float horizonalInput)
	{
		if(!canMoveInAir && !isGrounded)
		    return;

		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizonalInput * speed;
		myBody.velocity = moveVel;
	}
	*/

	//set to false
	public void Jump()
	{
		if(isGrounded)
			myBody.velocity += jumpVelocity * Vector2.up;
	}
}