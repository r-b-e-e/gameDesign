using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    private Animator anim;

    //playershooting
    private float timer = 0;
    private float delay = 0.25f;
    public GameObject bulletright;
    public GameObject bulletleft;
    public GameObject bulletdown;
    public GameObject bulletup;
    

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("left", true);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("right", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("up", true);
            anim.SetBool("left", false);
            anim.SetBool("down", false);
            anim.SetBool("right", false);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("up", false);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("rightw", true);
        }
        else
        {
            anim.SetBool("rightw", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("leftw", true);
        }
        else
        {
            anim.SetBool("leftw", false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("upw", true);
        }
        else
        {
            anim.SetBool("upw", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("downw", true);
        }
        else
        {
            anim.SetBool("downw", false);
        }

        playershooting();
    }

    void playershooting()
    {
        timer -= Time.deltaTime;

        //Animator anim = player.GetComponent<Animator>();
        if (Input.GetButton("Jump") && timer <= 0)
        {


            if ((anim.GetBool("right") || anim.GetBool("rightw")) && !anim.GetBool("left")
                && !anim.GetBool("leftw") && !anim.GetBool("up") && !anim.GetBool("upw") && !anim.GetBool("down") && !anim.GetBool("downw"))
            {
                Vector2 temp1 = transform.position;
                temp1.x = temp1.x + transform.localScale.x / 2;
                temp1.y = transform.position.y - 0.1f;
                Instantiate(bulletright, temp1, transform.rotation);
            }
            if ((anim.GetBool("left") || anim.GetBool("leftw")) &&
                !anim.GetBool("up") && !anim.GetBool("upw") && !anim.GetBool("down") && !anim.GetBool("downw"))
            {
                Vector2 temp2 = transform.position;
                temp2.x = temp2.x - transform.localScale.x / 2;
                temp2.y = transform.position.y - 0.1f;
                //Quaternion rot = transform.rotation;
                //rot.z = 180;
                Instantiate(bulletleft, temp2, transform.rotation);
            }
            if ((anim.GetBool("down") || anim.GetBool("downw")) && !anim.GetBool("up") && !anim.GetBool("upw"))
            {
                Vector2 temp3 = transform.position;
                temp3.y = temp3.y - transform.localScale.y / 2;

                //Quaternion rot = transform.rotation;
                //rot.z = 180;
                Instantiate(bulletdown, temp3, transform.rotation);
            }
            if (anim.GetBool("up") || anim.GetBool("upw"))
            {
                Vector2 temp4 = transform.position;
                temp4.y = temp4.y + transform.localScale.y / 2;

                //Quaternion rot = transform.rotation;
                //rot.z = 180;
                Instantiate(bulletup, temp4, transform.rotation);
            }
            timer = delay;
        }
    }
}
