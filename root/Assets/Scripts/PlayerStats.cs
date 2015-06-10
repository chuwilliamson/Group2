using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerStats : MonoBehaviour {


    public int MaxHealth = 100;
    public int currentHealth; 
	public Slider healthBar;
 
    bool damaged;
	// Use this for initialization
	void Start () {

        currentHealth = MaxHealth;
        
	}
	
	// Update is called once per frame
	void Update () {
			/* health bar shit = kyle's shit   */
		//healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Debug.Log(currentHealth);
            Destroy(gameObject);
            Application.LoadLevel("GameOverMenu");
        }

        }
 }  
  
 

   



