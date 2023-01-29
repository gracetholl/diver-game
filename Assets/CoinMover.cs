using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    float speed = 3;
    float outOfBounds = 8;
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up  * speed) * Time.deltaTime;

        if (transform.position.y > outOfBounds) {
            Debug.Log("Coin Deleted");
            Destroy(gameObject);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3 && logic.getActive()) {
            logic.addScore();
            Debug.Log("Grabbed Coin, Deleted");
        }
        Destroy(gameObject);
    }
}
