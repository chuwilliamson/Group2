using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerStats : MonoBehaviour {


    public int MaxHealth = 100;
    public int currentHealth; 
	public Slider healthBar;
    public GameObject GUISHIT;
    bool damaged;
    
	// Use this for initialization
	void Start () {

        currentHealth = MaxHealth;
        GUISHIT.SetActive(false);        
	}
	
	// Update is called once per frame


	void Update () {
			/* health bar shit = kyle's shit   */
		healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Debug.Log(currentHealth);
            Destroy(gameObject);
            //GUISHIT.SetActive(true);
            
            
           Application.LoadLevel("GameOverMenu");
        }

    }

    

    
 }  
  
 

   

/*

 void OnGUI()
    {
        if (paused)
        {
            GUILayout.BeginVertical(GUILayout.Height(Screen.height));
            {

                GUILayout.FlexibleSpace();

                GUILayout.Label("Game is paused.");
                if (GUILayout.Button("Unpause"))
                    paused = togglePause();
                if (GUILayout.Button("Quit."))
                    Application.Quit();
            }
            GUILayout.EndVertical();
        }

    }*/