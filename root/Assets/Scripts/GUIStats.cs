using UnityEngine;
using System.Collections;

public class GUIStats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        _hp.text = _pStats.currentHealth.ToString();
	}

    public PlayerStats _pStats;
    public GUIText _hp;
}
