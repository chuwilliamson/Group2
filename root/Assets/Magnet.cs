using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour {

	// Use this for initialization
    [SerializeField]
    private GameObject teleporter;
    [SerializeField]
    private Transform destination;
    [SerializeField]
    private GameObject player;

	 private void teleport(GameObject player, Transform destination)
    {

        player.transform.position = destination.transform.position;

    }

    // Update is called once per frame
     void OnTriggerEnter2D()
     {

         teleport(player, destination);
     }
}
