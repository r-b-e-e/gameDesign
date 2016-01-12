using UnityEngine;
using System.Collections;

public class AIPatrolScript : MonoBehaviour {
	private bool isPatrolling;
	public Vector3 startPoint;
	public Vector3 endPoint;
	private Vector3 destination;
	public float speed;
	public float thresholdRadius;
	private Animator anim;
	private Vector3 previousPosition;
	public Transform playerTransform;
	private bool isChasing;
    public GameObject blood;
    public GameObject ebullet;
    private float bulletdelay = 0.25f;
    private float enemyhealth = 100f;
    public GameObject player;
	// Use this for initialization
	void Start () {
		isPatrolling = true;
		destination = endPoint;
		anim = gameObject.GetComponent<Animator> ();
		previousPosition = transform.position;
		isChasing = false;
       
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		if (isChasing == false) {
			if (isPatrolling == true) {
				transform.position = Vector3.MoveTowards (transform.position, destination, step);
				if (transform.position == destination) {
					isPatrolling = false;
				}
			} else {
				if(transform.position == endPoint){
					destination = startPoint;
				}
				else if(transform.position == startPoint){
					destination = endPoint;
				}
				
				isPatrolling = true;
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, playerTransform.position, step);
		}
        if (!isChasing)
        {
            if (transform.position.x > previousPosition.x)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", true);
                anim.SetBool("IsLeftWalking", false);
                anim.SetBool("IsTopWalking", false);
                anim.SetBool("IsDownWalking", false);
                anim.SetBool("IsTleftWalking", false);
                anim.SetBool("IsDleftWalking", false);
                anim.SetBool("IsTrightWalking", false);
                anim.SetBool("IsDrightWalking", false);
            }
            else if (transform.position.x < previousPosition.x)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", false);
                anim.SetBool("IsLeftWalking", true);
                anim.SetBool("IsTopWalking", false);
                anim.SetBool("IsDownWalking", false);
                anim.SetBool("IsTleftWalking", false);
                anim.SetBool("IsDleftWalking", false);
                anim.SetBool("IsTrightWalking", false);
                anim.SetBool("IsDrightWalking", false);
            }
            else if (transform.position.y > previousPosition.y)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", false);
                anim.SetBool("IsLeftWalking", false);
                anim.SetBool("IsTopWalking", true);
                anim.SetBool("IsDownWalking", false);
                anim.SetBool("IsTleftWalking", false);
                anim.SetBool("IsDleftWalking", false);
                anim.SetBool("IsTrightWalking", false);
                anim.SetBool("IsDrightWalking", false);
            }
            else if (transform.position.y < previousPosition.y)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", false);
                anim.SetBool("IsLeftWalking", false);
                anim.SetBool("IsTopWalking", false);
                anim.SetBool("IsDownWalking", true);
                anim.SetBool("IsTleftWalking", false);
                anim.SetBool("IsDleftWalking", false);
                anim.SetBool("IsTrightWalking", false);
                anim.SetBool("IsDrightWalking", false);
            }
            else
            {
                anim.SetBool("IsMoving", false);
            }
        } else
        {
            if (transform.position.x > playerTransform.position.x)
            {
                if((playerTransform.position.x < (transform.position.x - 0.25)) && 
                    (playerTransform.position.y < (transform.position.y + 0.25) && playerTransform.position.y > (transform.position.y - 0.25)))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", true);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if(playerTransform.position.x > (transform.position.x - 0.25) && 
                    playerTransform.position.y > (transform.position.y + 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", true);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if(playerTransform.position.y > (transform.position.y + 0.25) && 
                    playerTransform.position.x < (transform.position.x - 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", true);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if(playerTransform.position.x > (transform.position.x - 0.25) &&
                    playerTransform.position.y < (transform.position.y - 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", true);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if(playerTransform.position.x < (transform.position.x - 0.25) && 
                    playerTransform.position.y < (transform.position.y - 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", true);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }

                
            }
            else if (transform.position.x < playerTransform.position.x)
            {
                if ((playerTransform.position.x > (transform.position.x + 0.25)) &&
                    (playerTransform.position.y < (transform.position.y + 0.25) && playerTransform.position.y > (transform.position.y - 0.25)))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", true);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if (playerTransform.position.x < (transform.position.x + 0.25) &&
                   playerTransform.position.y > (transform.position.y + 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", true);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if (playerTransform.position.y > (transform.position.y + 0.25) &&
                  playerTransform.position.x > (transform.position.x + 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", true);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if (playerTransform.position.x < (transform.position.x + 0.25) &&
                   playerTransform.position.y < (transform.position.y - 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", true);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsTrightWalking", false);
                    anim.SetBool("IsDrightWalking", false);
                }
                else if (playerTransform.position.x > (transform.position.x + 0.25) &&
                  playerTransform.position.y < (transform.position.y - 0.25))
                {
                    anim.SetBool("IsMoving", true);
                    anim.SetBool("IsRightWalking", false);
                    anim.SetBool("IsLeftWalking", false);
                    anim.SetBool("IsTopWalking", false);
                    anim.SetBool("IsDownWalking", false);
                    anim.SetBool("IsTleftWalking", false);
                    anim.SetBool("IsDleftWalking", false);
                    anim.SetBool("IsDrightWalking", true);
                    anim.SetBool("IsTrightWalking", false);
                    
                }
            }
           /* else if (transform.position.y > playerTransform.position.y)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", false);
                anim.SetBool("IsLeftWalking", false);
                anim.SetBool("IsTopWalking", false);
                anim.SetBool("IsDownWalking", true);
            }
            else if (transform.position.y < playerTransform.position.y)
            {
                anim.SetBool("IsMoving", true);
                anim.SetBool("IsRightWalking", false);
                anim.SetBool("IsLeftWalking", false);
                anim.SetBool("IsTopWalking", true);
                anim.SetBool("IsDownWalking", false);
            }*/
            else
            {
                anim.SetBool("IsMoving", false);
            }

            bulletdelay -= Time.deltaTime;
            if(bulletdelay <= 0)
            {
                Instantiate(ebullet, transform.position, transform.rotation);
                bulletdelay = 0.25f;
            }
            
        }
		

		previousPosition = transform.position;
		findPlayer ();
	}

	private void findPlayer(){
		if ((playerTransform.position - transform.position).magnitude < thresholdRadius) {
			isChasing = true;
		} else {
			isChasing = false;
		}
	}

    

    /*public void bulletcollision()
    {
        Vector3 temp = transform.position;
        Quaternion rot = transform.rotation;
        Destroy(gameObject);
        Instantiate(blood, temp, rot);
        
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "bullet")
        {
            enemyhealth -= 25f;
            if(enemyhealth <= 0)
            {
                Vector3 temp = transform.position;
                Quaternion rot = transform.rotation;
                Destroy(this.gameObject);
                Instantiate(blood, temp, rot);
                if(Application.loadedLevel == 1)
                {
                    player.GetComponent<playermovement>().scoreupdate(10);
                }
                if (Application.loadedLevel == 2)
                {
                    player.GetComponent<playermovement2>().scoreupdate(10);
                }
                
            }
        }
    }
}
