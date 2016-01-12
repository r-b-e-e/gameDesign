using UnityEngine;
using System.Collections;

public class ebulletr : MonoBehaviour {

    // Use this for initialization

    private float speed = 5;
    private float delay = 0.25f;

    // Update is called once per frame
    void Update () {
        float step = speed * Time.deltaTime;
       // playermovement player = GameObject.FindWithTag("Player").GetComponent<playermovement>();
        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindWithTag("Player").transform.position, step);
        //delay -= Time.deltaTime;
       
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            float health;
            health = GameObject.FindWithTag("Health").GetComponent<playerhealth>().phealth;
            GameObject.FindWithTag("Health").GetComponent<playerhealth>().phealth = health - 2.0f;
            Destroy(this.gameObject);
        }
    }
}
