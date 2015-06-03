using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

void DoIan()
    {

    }

    void DoBeaux()
{

}

    public void LoadLevel(string level)
    {
        //if (level == "whatever")
        //{
        //    print("be like come on dog its art");
        //    print("string is " + level);
        //}
        //else
        //{
            Application.LoadLevel("FinalGame");
            //Application.LoadLevel(0);
       // }
    }

    //public void Update()
    //{

    //    if (Input.GetKeyDown("p"))
    //    {

    //        Application.LoadLevel("Pause");
    //    }


    //}

    public void Win(string level)
    {

        Application.LoadLevel("StartMenu");

    }

}
