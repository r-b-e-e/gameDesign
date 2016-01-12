using UnityEngine;
using System.Collections;

public class playershooting : MonoBehaviour {
	private float timer = 0;
	private float delay = 0.25f;
	public GameObject bulletright;
	public GameObject bulletleft;
	public GameObject bulletdown;
	public GameObject bulletup;
	public GameObject player ;


	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		Animator anim = player.GetComponent<Animator>();
		if (Input.GetButton ("Jump") && timer <= 0) {


			if(anim.GetBool("right") || anim.GetBool("rightw")){
				Vector2 temp1 = transform.position;
				temp1.x = temp1.x + transform.localScale.x/2;
				temp1.y = transform.position.y - 0.1f;
				Instantiate(bulletright, temp1, transform.rotation);
			}
			if(anim.GetBool("left") || anim.GetBool("leftw")){
				Vector2 temp2 = transform.position;
				temp2.x = temp2.x - transform.localScale.x/2;
				temp2.y = transform.position.y - 0.1f;
				//Quaternion rot = transform.rotation;
				//rot.z = 180;
				Instantiate(bulletleft, temp2, transform.rotation);
			}
			if(anim.GetBool("down") || anim.GetBool("downw")){
				Vector2 temp3 = transform.position;
				temp3.y = temp3.y - transform.localScale.y/2;

				//Quaternion rot = transform.rotation;
				//rot.z = 180;
				Instantiate(bulletdown, temp3, transform.rotation);
			}
			if(anim.GetBool("up") || anim.GetBool("upw")){
				Vector2 temp4 = transform.position;
				temp4.y = temp4.y + transform.localScale.y/2;
				
				//Quaternion rot = transform.rotation;
				//rot.z = 180;
				Instantiate(bulletup, temp4, transform.rotation);
			}
			timer = delay;
		}
	}
}
