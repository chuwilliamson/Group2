/*
#pragma strict

gameObject.tag = "Player";

var playerHealth = 3;

function Start () {

}

function Update () {

}

function OnCollisionEnter (collision : Collision)
{
	if(collision.transform.name == ("Enemy"))
	{
		playerHealth -=1;
	}
	
		else if(playerHealth <= 0)
		{
			Destroy(GameObject);
		}
}
	*/