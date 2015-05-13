using UnityEngine;
using System.Collections;

public class MedPack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public int heal = 5;
	// Update is called once per frame
    void OnCollisionEnter2D (Collision2D col)
    {
        Player.GetComponent<PlayerStats>().currentHealth += heal;

            Destroy(this.gameObject);
       }
    

    public GameObject Player;
   
}
