using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class medical : MonoBehaviour {

    Text text;
    public int pain = 0;
    public GameObject player;
    private playermovement playerm;
    private int s;
    private bool incre;
    

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        playerm = player.GetComponent<playermovement>();
	}
	
	// Update is called once per frame
	void Update () {
        s = playerm.score;
        if((s==25 || s==30 ) && !incre)
        {
            pain += 1;
            incre = true;
        }
        text.text = "Pain killers: " + pain;
	}
}
