using UnityEngine;
using System.Collections;

public class spiketrig : MonoBehaviour {

   
    public GameObject spike;


    void OnTriggerEnter2D()
    {
        spike.GetComponent<Rigidbody2D>().isKinematic = false;

    }
   
  
}

