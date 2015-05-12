using UnityEngine;
using System.Collections;


public class Bomb : MonoBehaviour {
    void Start()
    {}
    public int damage = 15;

	void OnCollisionEnter2D (Collision2D col) {

        Player.GetComponent<PlayerStats>().currentHealth -= damage;

        //if (col.gameObject.name == "Bomb")
        //{

            Destroy(this.gameObject);
        //}
	
	}

    [SerializeField]
    GameObject Player;
}
