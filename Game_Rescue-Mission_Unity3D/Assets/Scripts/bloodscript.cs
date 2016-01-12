using UnityEngine;
using System.Collections;

public class bloodscript : MonoBehaviour {

    private float timer = 1f;

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;

        Vector3 temp = this.gameObject.transform.localScale;

        temp.x -= 0.02f;
        temp.y -= 0.02f;
        this.gameObject.transform.localScale = temp;


        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
