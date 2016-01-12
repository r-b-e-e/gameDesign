using UnityEngine;
using System.Collections;

public class playermovement2 : MonoBehaviour {

    public float speed = 4f;
    private float horizontal;
    private float vertical;
    private Animator anim;
    public GameObject player;
    public int score;
    public GUIText scoretext;
    private GameObject[] enemy;
    private GameObject[] coin;
    private savescore levelscoreupdate = new savescore();

    // Use this for initialization
    void Start () {
        anim = player.GetComponent<Animator>();
        score = levelscoreupdate.levelscore;
        updatescore();
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        coin = GameObject.FindGameObjectsWithTag("coin");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = transform.position;
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        coin = GameObject.FindGameObjectsWithTag("coin");
        Debug.Log("enemies: " + enemy.Length);
        Debug.Log("coins: " + coin.Length);

        if (anim.GetBool("rightw"))
        {
            //horizontal = 1;
            Debug.Log("rightwalk");
            temp.x += speed * Time.deltaTime;
        }

        if (anim.GetBool("leftw"))
        {
            temp.x -= speed * Time.deltaTime;
        }

        if (anim.GetBool("upw"))
        {
            temp.y += speed * Time.deltaTime;
        }

        if (anim.GetBool("downw"))
        {
            temp.y -= speed * Time.deltaTime;
        }

        player.transform.position = temp;
	}

    //coin
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "coin")
        {
            Destroy(col.gameObject);
            score += 5;
            updatescore();
        }
        if(col.tag == "key")
        {
            Destroy(col.gameObject);
            GameObject.FindWithTag("rescuedoor").GetComponent<rescuedoor>().keytaken = true;
        }
        if(col.tag == "girl")
        {
            Debug.Log("Touched Girl");
            if (enemy.Length == 0 && coin.Length == 0)
            {
                Application.LoadLevel(4);
            }
        }
        
    }

    //SCORE
    void updatescore()
    {
        scoretext.text = "SCORE: " + score;
    }

    public void scoreupdate(int incre)
    {
        score += incre;
        updatescore();
    }
}
