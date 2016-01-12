using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour {

    // public float xplacement;
    //public float yplacement;
    private float timedelay1 = 8f;
    private float timedelay2 = 8f;
    public Canvas dialogue;
    public GameObject health;
    public GameObject medical;
    
    void Awake()
    {
        
    }
	/*void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width * xplacement, Screen.height * yplacement, Screen.width * 0.25f, Screen.height * 0.1f),
            "Start the mission")){
            Application.LoadLevel(1);
        }
    }*/
    void Update()
    {
        

        if (Application.loadedLevel == 1)
        {
            if(timedelay1 > 0)
            {
                timedelay1 -= Time.deltaTime;
            }
            if(timedelay1 <= 0)
            {
                dialogue.enabled = false;
            } 
        }
        

        if(Application.loadedLevel == 2)
        {
            if(timedelay2 > 0)
            {
                timedelay2 -= Time.deltaTime;
            }
            if(timedelay2 <= 0)
            {
                dialogue.enabled = false;
            }
        }
    }

    public void startgame()
    {
        Application.LoadLevel(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }

    public void pain()
    {
        if(medical.GetComponent<medical>().pain > 0 && medical.GetComponent<medical>().pain < 50)
        {
            health.GetComponent<playerhealth>().healthupdate(50);
            medical.GetComponent<medical>().pain -= 1;
        }
        
    }
}
