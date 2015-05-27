using UnityEngine;
using System.Collections;

public class Magnet2 : MonoBehaviour
{
    [SerializeField]
    private Transform destination;

    public float power2 = 100;
    //public Vector3 teleportPoint;
    public Rigidbody2D rd;
    void Start()
    {

    }


    void OnTriggerStay2D()
    {
        rd.AddForce(Vector2.right * power2);
    }
}