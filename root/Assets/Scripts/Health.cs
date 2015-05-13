

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                            
    public int currentHealth;                                   
    public Slider healthSlider;                                 
    public Image damageImage;                                   
    public AudioClip deathClip;                                 
    public float flashSpeed = 5f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     


                               
    bool isDead;                                                
    bool damaged;                                               


    void Awake()
    {
        

       
        currentHealth = startingHealth;
    }


    void Update()
    {
       
       
    }


    public void TakeDamage(int amount)
    {
        

        
        currentHealth -= amount;

       
        healthSlider.value = currentHealth;

      

       
        if (currentHealth <= 0 && !isDead)
        {
       
            Death();
        }
    }


    void Death()
    {
        
        isDead = true;

       
    }
}



















/*using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public int startingHealth = 100;
    public int currentHealth;
    bool damaged;
    bool isDead;
	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;

	}
	
	// Update is called once per frame
	public void TakeDamage (int amount) {
        currentHealth -= amount;

        if(currentHealth <=0)
        {
           

        }
    
    }
      
        }
	
	
*/
