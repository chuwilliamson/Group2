using UnityEngine;
using System.Collections;


public class LevelTrig : MonoBehaviour {

    public GameObject door;
   

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D datColl) {
        if(datColl.gameObject.tag == "Player")
        {
            Debug.Log("datcoll is dat playa");
            StartCoroutine(spawn());

           

        }
       
	
	}
	

    IEnumerator spawn()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(door);
            
            
           // yield return new OnCollisionEnter2D(Collision2D (coll));
            
        }
        yield return null;

    }
	// Update is called once per frame
	void Update() {

        
	
	}
}
