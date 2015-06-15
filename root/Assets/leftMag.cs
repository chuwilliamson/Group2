using UnityEngine;
using System.Collections;

public class leftMag : MonoBehaviour {

    [SerializeField]
    private Transform destination;

    public float power = 100;
    //public Vector3 teleportPoint;
    public Rigidbody2D rb;
    void Start()
    {

    }


    void OnTriggerStay2D()
    {
        rb.AddForce(Vector3.left * power);
    }
}

