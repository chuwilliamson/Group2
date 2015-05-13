/*
using UnityEngine;
using System.Collections;

public class WeaponSwapController : MonoBehaviour {

	public GameObject[] weapons; //pushes prefabs

	public int currentWeapon = 0;

	private int nrWeapons;

	// Use this for initialization
	void Start () {
		nrWeapons = weapons.Length;

		SwitchWeapon(currentWeapon); //set default weapon

	}
	
	// Update is called once per frame
	void Update () {
		for (int i=1; i<= nrweapons; i++) {
			if(Input.GetKeyDown("" + i)); {
				currentWeapon = i-1;

				SwitchWeapon(currentWeapon);
			
			
			}
	}
}

	void SwitchWeapon(int index) {

		for (int i=0; i < nrweapos; i++)	{
			if(i == index)	{
				weapons[i].gameObject.SetActive(true);
			} else {
				weapons[i].gameObject.SetActive(false);
			}
		}
	}

}
*/