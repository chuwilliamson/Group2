using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {

  
            GUILayout.BeginVertical(GUILayout.Height(Screen.height));
            {

                GUILayout.FlexibleSpace();

                GUILayout.Label("");
                if (GUILayout.Button("Restart"))
                    Application.LoadLevel(Application.loadedLevel);
            }
       
        GUILayout.EndVertical();
    }
}
