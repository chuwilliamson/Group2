using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void OnTriggerEnter2D()
    {
        Application.LoadLevel("Win");

    }


    //public void LoadLevel(string level)
    //{
        
    //    Application.LoadLevel("StartMenu");
	
    //}
}
