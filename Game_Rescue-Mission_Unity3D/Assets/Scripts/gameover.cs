using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

    public float xplacement;
    public float yplacement;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width * xplacement, Screen.height * yplacement, Screen.width * 0.25f, Screen.height * 0.1f),
            "Play Again"))
        {
            Application.LoadLevel(1);
        }
    }
}
