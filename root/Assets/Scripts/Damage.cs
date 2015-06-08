using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	// Use this for initialization
	 public int damage = 100;

     void OnCollisionEnter2D(Collision2D col)
     {
         if(col.gameObject.CompareTag("Player"))
            Player.GetComponent<PlayerStats>().currentHealth -= damage;
     }
	
	// Update is called once per frame
	void Update () {

	
	}
    [SerializeField]
    GameObject Player;
}
