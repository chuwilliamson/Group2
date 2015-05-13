#pragma strict

var TheDamage : int = .5;
var Distance : float;
var MaxDistance : float = 1.5;
var anim : Animator;

function Start () 
{
	

}

function Update () 
{
	if (Input.GetButtonDown("Fire1"))
	{
		Debug.Log("fire1 pressed");
		anim.SetTrigger("Fire1");
		
		/*
		
		var hit : RaycastHit;
		if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), hit))
		{
			Distance = hit.distance;
			if (Distance < MaxDistance)
			hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
			
		}
		*/
	}
}