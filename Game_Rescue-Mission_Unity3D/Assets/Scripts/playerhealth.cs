using UnityEngine;
using System.Collections;

public class playerhealth : MonoBehaviour {

    public GameObject player;
    public float phealth;
    private float playermaxhealth = 100f;
    public SpriteRenderer foregroundsprite;
    public Transform foregroundscale;

    public float enemyhealth = 100f;
	// Use this for initialization
	void Awake () {
        phealth = playermaxhealth;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 temp = player.transform.position;
        temp.y += 0.4f;
        transform.position = temp;

        float healthpercent = phealth / playermaxhealth;
        if(phealth >= 0)
        {
            foregroundscale.localScale = new Vector3(healthpercent, 1, 1);
        }else
        {
            Application.LoadLevel(3);
        }
        
        foregroundsprite.color = Color.green;
	}
    public void healthupdate(int i)
    {
        phealth += i;
    }
}
