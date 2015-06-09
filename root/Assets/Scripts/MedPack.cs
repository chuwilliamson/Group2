using UnityEngine;
using System.Collections;

public class MedPack : MonoBehaviour {
    private GameObject Med;
    public int heal = 15;
   
    void OnTriggerEnter2D ()
    {
         Player.GetComponent<PlayerStats>().currentHealth += heal;

        if (Med = GameObject.FindGameObjectWithTag("MedPack"))
        {

            Destroy(this.gameObject);
        }
     }
    
    [SerializeField]
     GameObject Player;
   
}
