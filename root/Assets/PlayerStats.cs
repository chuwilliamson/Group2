using UnityEngine;
using System.Collections;


public class PlayerStats : MonoBehaviour {


    public int MaxHealth = 100;
    public int currentHealth;
   
    bool damaged;
	// Use this for initialization
	void Start () {

        currentHealth = MaxHealth;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	
        if (currentHealth <= 0)
        {
            Debug.Log(currentHealth);
            Destroy(gameObject);
        }
    }

    
    
}



