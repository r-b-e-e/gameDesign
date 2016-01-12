using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {

    public float speed = 4f;
    private float horizontal;
    private float vertical;
    private Animator anim;
    public GameObject player;
    public  int score;
    public GUIText scoretext;
    

    // Use this for initialization
    void Start () {
        anim = player.GetComponent<Animator>();
        score = 0;
        updatescore();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 temp = transform.position;

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
