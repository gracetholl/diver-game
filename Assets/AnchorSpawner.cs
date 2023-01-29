using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorSpawner : MonoBehaviour
{
    
    public Logic logic;
    public GameObject anchor;

    public float rate = 5;
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
            spawn();
            timer = 0;
        }

        
    }

    void spawn() {

        float leftmost = -5.5f;
        float rightmost = 5.5f;

        Instantiate(anchor, new Vector3(Random.Range(leftmost, rightmost), 15f, 0),
        transform.rotation);
        
    }

}
