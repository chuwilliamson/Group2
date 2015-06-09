using UnityEngine;
using System.Collections;


public class Bomb : MonoBehaviour {
    private GameObject Bombs;
    void Start()
    {}
    public int damage = 15;

	void OnTriggerEnter2D () {

        Player.GetComponent<PlayerStats>().currentHealth -= damage;

        if (Bombs = GameObject.FindGameObjectWithTag("Bomb"))
        {

            Destroy(this.gameObject);
        }
	
	}

    [SerializeField]
    GameObject Player;
}
