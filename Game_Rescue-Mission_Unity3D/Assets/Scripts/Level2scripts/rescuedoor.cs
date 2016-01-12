using UnityEngine;
using System.Collections;

public class rescuedoor : MonoBehaviour {


    public GUIText timetext;
    public GUIText bombtext;
    private int doortouch;
    private bool bombtrigger;
    private int time;
    private int textcolorint;
    public bool keytaken;
    public GameObject rescuedoorcollider;
    public GameObject key;
    public Canvas bombcanvas;
    private float timedelay;

    void Start()
    {
        //timetext.color = Color.red;
        doortouch = 0;
        time = 2000;
        textcolorint = 9;
        keytaken = false;
        timedelay = 0.0f;
    }
    // Update is called once per frame
    void Update () {
        textcolorint -= 1;
        if(textcolorint == 9 && bombtrigger)
        {
            timetext.color = Color.red;
            bombtext.color = Color.green;
        }else if(textcolorint == 6 && bombtrigger)
        {
            timetext.color = Color.green;
            bombtext.color = Color.red;
        }
        else if(textcolorint == 3 && bombtrigger)
        {
            timetext.color = Color.blue;
            bombtext.color = Color.blue;
        }
        else if(textcolorint == 1)
        {
            textcolorint = 9;
        }

        if (bombtrigger)
        {
            if(time > 0)
            {
                timetext.text = "TIME: " + time;
                bombtext.text = "BOMB ACTIVATED !!";
                time -= 1;
            }else if(time <= 0)
            {
                Application.LoadLevel(3);
                
            }
        }

        //canvas
        if(timedelay > 0)
        {
            timedelay -= Time.deltaTime;
        }
        if(doortouch > 0 && timedelay <= 0)
        {
            bombcanvas.enabled = false;
        }
       
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        
            
            if (col.tag == "Player")
            {
                doortouch += 1;
                if(doortouch == 1)
                {
                    bombtrigger = true;
                    key.SetActive(true);
                    bombcanvas.enabled = true;
                    timedelay = 7.0f;
                }

                if (keytaken)
                {
                    Destroy(rescuedoorcollider);
                    Destroy(this.gameObject);
                    bombtrigger = false;
                    timetext.text = "";
                    bombtext.color = Color.green;
                    bombtext.text = "BOMB DEACTIVATED !!";
            }
                //Debug.Log("hit");

                //Application.LoadLevel(2);
            }
       
        
    }
}
