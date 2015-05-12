using UnityEngine;
using System.Collections;

public class bossTrig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {

        
        Debug.Log("Boss");
    }

}
