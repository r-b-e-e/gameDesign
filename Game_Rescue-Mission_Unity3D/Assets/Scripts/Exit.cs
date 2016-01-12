using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("hit");
            Application.LoadLevel(2);
        }
    }
}
