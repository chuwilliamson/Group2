using UnityEngine;
using System.Collections;
using UnitySampleAssets._2D;
using UnitySampleAssets.CrossPlatformInput;

public class Trap : MonoBehaviour
{

    private GameObject fTrap;
    [SerializeField]
    private GameObject player;

    // Use this for initialization
    private void trap(GameObject player)
    {



    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D p)
    {
        //if p is the player disable player controller
        GameObject dudeGotHit = p.gameObject;
        dudeGotHit.GetComponent<PlatformerCharacter2D>().maxSped = 0;
        StartCoroutine(Wiggle(20, dudeGotHit));
    }

    void Update()
    {

 
    }

    IEnumerator Wiggle(float threshold, GameObject dude)
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        if (threshold <= 0)
        {
            dude.GetComponent<PlatformerCharacter2D>().maxSped = 2;
             yield return null;
        }
           
       
            
                print("wiggle");
                threshold--;
                StartCoroutine(Wiggle(threshold, dude));
            }
        
    }


