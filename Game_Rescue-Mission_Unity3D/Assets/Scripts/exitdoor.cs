using UnityEngine;
using System.Collections;

public class exitdoor : MonoBehaviour {

    //public GameObject exitprefab;
    private GameObject[] enemy;
    private GameObject[] coin;
    public GameObject exitcollider;
    public SpriteRenderer exitdoorfront;
    private bool exit = false;
    private savescore scoreupdate = new savescore();

    void Start()
    {
        exitdoorfront.color = Color.red;
    }
    // Update is called once per frame
    void Update () {
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        coin = GameObject.FindGameObjectsWithTag("coin");
        //Debug.Log("enemies: " + enemy.Length);
        //Debug.Log("coins: " + coin.Length);
        if (enemy.Length == 0 && coin.Length == 0)
        {
           // Instantiate(exitprefab, transform.position, transform.rotation);
            Destroy(exitcollider);
            exitdoorfront.color = Color.green;
            exit = true;
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (exit)
        {
            if (col.tag == "Player")
            {
                Debug.Log("hit");
                int sc = col.GetComponent<playermovement>().score;
                scoreupdate.levelscoreupdate(sc);
                Application.LoadLevel(2);
            }
        }
        
    }
}
