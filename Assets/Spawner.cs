using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject angler;
    public GameObject jelly;
    public GameObject squid;
    public float rate = 1;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate) {
            timer += Time.deltaTime;
        }
        else {
            int obj = Random.Range(1, 4);
            spawn(obj);
            timer = 0;
        }

    }

    void spawn(int obj) {

        float leftmost = -4f;
        float rightmost = 4f;

        if (obj == 1) {
            Instantiate(angler, new Vector3(Random.Range(leftmost, rightmost), -15f, 0),
             transform.rotation);
        }
        else if (obj == 2) {
            Instantiate(jelly, new Vector3(Random.Range(leftmost, rightmost), -15f, 0),
             transform.rotation);
        }
        else if (obj == 3) {
            Instantiate(squid, new Vector3(Random.Range(leftmost, rightmost), -15f, 0),
             transform.rotation);
        }
    }
}
