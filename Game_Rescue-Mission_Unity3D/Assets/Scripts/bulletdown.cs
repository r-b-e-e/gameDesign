using UnityEngine;
using System.Collections;

public class bulletdown : MonoBehaviour {
	private float speed = 10f;
    private float enemyhealth = 100f;

    // Update is called once per frame
    void Update () {
		Vector2 temp = transform.position;
		temp.y -= speed * Time.deltaTime;
		transform.position = temp;
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "collider" || target.tag == "enemy") {
			Destroy(this.gameObject);
           /* if (target.tag == "enemy")
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
