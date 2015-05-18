using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour
{
    [SerializeField]
    private Transform destination;

    public float power = 100;
    //public Vector3 teleportPoint;
    public Rigidbody2D rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    //void OnTriggerEnter2D()
    //{
      //  rb.MovePosition(transform.position + transform.right * Time.deltaTime);
    //}

    void OnTriggerStay2D()
    {
        rb.AddForce(Vector2.right * power);
    }
}



	/*
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
    */