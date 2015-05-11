#pragma strict

var currentWeapon = 0;
var maxWeapons = 4;
var TheAnimator : Animator;
//var WeaponArray[] : ArrayList;

function Awake () 
{
	SelectWeapon(0);
}

function Update () 
{
	if(Input.GetAxis("Mouse ScrollWheel") < 0)
	{
		if(currentWeapon + 1 <= maxWeapons)
			{
				currentWeapon++;
			}
			else
			{
				currentWeapon = 0;
			}
			SelectWeapon(currentWeapon);
	}
	else if (Input.GetAxis("Mouse ScrollWheel") > 0)
	{
		if(currentWeapon - 1 >= 0)
		{
			currentWeapon--;
		}
		else
		{
			currentWeapon = maxWeapons;
		}
		SelectWeapon(currentWeapon);
	}
	
	if(currentWeapon == maxWeapons + 1)
		{
			currentWeapon = 0;
		}
	if(currentWeapon == -1)
		{
			currentWeapon = maxWeapons;
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			currentWeapon = 0;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			currentWeapon = 1;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			currentWeapon = 2;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			currentWeapon = 3;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			currentWeapon = 4;
			SelectWeapon(currentWeapon);
		}
		/*
		if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			currentWeapon = 5;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha6))
		{
			currentWeapon = 6;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha7))
		{
			currentWeapon = 7;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha8))
		{
			currentWeapon = 8;
			SelectWeapon(currentWeapon);
		}
		if(Input.GetKeyDown(KeyCode.Alpha9))
		{
			currentWeapon = 9;
			SelectWeapon(currentWeapon);
		}
		*/
		
		
}

function SelectWeapon (index : int)
{
	for (var i = 0; i < transform.childCount; i++)
	{
		//Activate the selected weapon
		if(i == index)
		{ 
			if (transform.GetChild(i).name == "Default")
			{
				TheAnimator.SetBool("WeaponOn", false);
			}
			else
			{
				TheAnimator.SetBool("WeaponOn", true);
			}
			transform.GetChild(i).gameObject.SetActive(true);
		}
		else
		{
		 	transform.GetChild(i).gameObject.SetActive(false);
		}
	}
}

