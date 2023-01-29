using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public float rate = 1.0f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
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

        float leftmost = -4.5f;
        float rightmost = 4.5f;

        Instantiate(coin, new Vector3(Random.Range(leftmost, rightmost), -15f, 0),
        transform.rotation);
        
    }
}
