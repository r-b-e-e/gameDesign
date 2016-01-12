using UnityEngine;
using System.Collections;

public class bulletleft : MonoBehaviour {
	private float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Animator anim = GameObject.Find("player_walking").GetComponent<Animator> ();
		//if (anim.GetBool ("left") || anim.GetBool("leftw")) {
			Vector2 temp1 = transform.position;
			temp1.x -= speed * Time.deltaTime;
			transform.position = temp1;

	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "collider" || target.tag == "enemy") {
			Destroy(this.gameObject);
            /*if (target.tag == "enemy")
            {
                playerhealth enemyhealth = GameObject.FindWithTag("Health").GetComponent<playerhealth>();
                float ehealth = enemyhealth.enemyhealth;
                ehealth -= 25f;
                GameObject.FindWithTag("Health").GetComponent<playerhealth>().enemyhealth = ehealth;

                if (ehealth <= 0)
                {
                    target.gameObject.GetComponent<AIPatrolScript>().bulletcollision();
                }

            }*/
        }
	}
}
