using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerStats : MonoBehaviour {


    public int MaxHealth = 100;
    public int currentHealth;
   // public float health;
    //public Slider healthBar; 
   
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
            Application.LoadLevel("GameOverMenu");
        }

        }


  /*  public void adjustCurrentHealth(int adjustment)
    {
        if (health > MaxHealth)
            health = MaxHealth;
        if (currentHealth < 1)
            currentHealth = 1;
        healthBar.value = currentHealth;
        //health -= gameObject.GetComponent<CEnemy>().attackDamage;
    }*/
}

   



