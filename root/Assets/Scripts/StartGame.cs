using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public bool isStart;
    public bool isQuit;
	// Update is called once per frame
    void OnMouseUp()
    {
        if (isStart)
        {
          //  Application.LoadLevel(class_game.unity);
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }
}
