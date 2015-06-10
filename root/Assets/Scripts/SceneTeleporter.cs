using UnityEngine;
using System.Collections;

public class SceneTeleporter : MonoBehaviour {

	[SerializeField]
	private GameObject teleporter;
	[SerializeField]
	private GameObject player;
	public string Level;

	// Use this for initialization
	void OnTriggerEnter2D()
	{
		Application.LoadLevel(Level);
	}
	// Update is called once per frame
	void Update()
	{

	}

	/*
	function OnTriggerEnter (other: Collider){
		Application.LoadLevel( 2);
	}
	*/
}