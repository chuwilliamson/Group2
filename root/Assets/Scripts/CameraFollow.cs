using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	GameObject target;
	public float speed;
	Vector3 followDir;
	public bool targetPlayer;
	
	void FixedUpdate () 
	{
		if(targetPlayer)
		{
			target = GameObject.FindGameObjectWithTag("Player");
		}

		   followDir = (target.transform.position - transform.position).normalized; 
		   if((transform.position - target.transform.position).sqrMagnitude > 4)
				{
					GetComponent<Rigidbody>().AddForce(new Vector3(0, followDir.y, 0) * speed);
				}
	}
}