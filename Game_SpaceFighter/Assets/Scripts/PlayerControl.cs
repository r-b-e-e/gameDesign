using UnityEngine;
using System.Collections;


public class PlayerControl : MonoBehaviour
{
    public float fast;
    public float tilt1;
    public float tilt2;

    public Limit limit;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    void FixedUpdate() //called before each physics steps
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0.0f, verticalMove);
        GetComponent<Rigidbody>().velocity = fast * move;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, limit.xMin, limit.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, limit.zMin, limit.zMax)
        );
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt1);
        //        GetComponent<Rigidbody>().rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.z * tilt2, 0.0f, 0.0f);
    }

    void Update() // execute before every frame
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //            GameObject clone = Instantiate(Projector, transform.positon, transform.rotation) as GameObject
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play(); 
        }

    }
}

[System.Serializable]
public class Limit
{
    public float xMax, xMin, zMax, zMin;
}