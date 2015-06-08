using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour
{

    public int damage = 100;
    private bool tookDamage = false;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!tookDamage)
        {

            if (col.gameObject.tag == "Player")
            {

                Player.GetComponent<PlayerStats>().currentHealth -= damage;
                tookDamage = true;
            }
            
        }

    }

    [SerializeField]
    GameObject Player;


}
