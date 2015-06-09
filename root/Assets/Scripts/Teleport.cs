using UnityEngine;


public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject teleporter;
    [SerializeField]
    private Transform destination;
   [SerializeField]
    private GameObject player;

    // Use this for initialization
    private void teleport(GameObject player, Transform destination)
    {

        player.transform.position = destination.transform.position;

    }
    
    // Update is called once per frame
    void Update()
    {

       // player.transform.position = destination.transform.position;
       teleport(player, destination);
       Debug.Log("Its in");
    }


}
