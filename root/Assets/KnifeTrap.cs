using UnityEngine;
using System.Collections;

public class KnifeTrap : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}