using UnityEngine;


public class bounce : MonoBehaviour {
    [SerializeField]
	private GameObject teleporter;
    [SerializeField]
    private Transform destination;
    [SerializeField]
    private GameObject player;

	// Use this for initialization
	private void teleport (GameObject player, Transform destination) {

        player.transform.position = destination.transform.position;

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D coll){

        teleport(player, destination);
		Debug.Log ("Its in");
	}


}
