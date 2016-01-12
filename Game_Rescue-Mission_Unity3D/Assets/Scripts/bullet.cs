using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	private float speed = 10;
    public GameObject blood;
    
  
	
	// Update is called once per frame
	void Update () {
		//Animator anim = GameObject.Find("player_walking").GetComponent<Animator> ();


		//if (anim.GetBool ("right") || anim.GetBool("rightw")) {
			Vector2 temp = transform.position;
			temp.x += speed * Time.deltaTime;
			transform.position = temp;


	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "collider" || target.tag == "enemy") {
            Vector3 temp = transform.position;
            Quaternion rot = transform.rotation;
            Destroy(this.gameObject);
            /*if(target.tag == "enemy")
            {
                playerhealth enemyhealth = GameObject.FindWithTag("Health").GetComponent<playerhealth>();
                float ehealth = enemyhealth.enemyhealth;

                ehealth -= 25f;
                GameObject.FindWithTag("Health").GetComponent<playerhealth>().enemyhealth = ehealth;

                if (ehealth <= 0)
                {
                    target.gameObject.GetComponent<AIPatrolScript>().bulletcollision();
                }
                
                
                //Instantiate(GameObject.FindWithTag("blood"), temp, rot);
            }*/
		}
	}
}
