using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 4;
    public float outOfBounds = 9;
    public Logic logic;

    // Start is called before the first frame update
    void Start()
    {
       //transform.position += new Vector3(Random.Range(-3, 5), 0, 0);
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up  * speed) * Time.deltaTime;

        if (transform.position.y > outOfBounds) {
            Debug.Log("Enemy Deleted");
            Destroy(gameObject);
        }
    }
/*
    private void OnCollisonEnter2D(Collision2D collision) {
        Debug.Log("ENEMY COLLISION");
        if (collision.gameObject.layer == 3 && logic.getActive()) {
            Debug.Log("DIVER Hit Enemy");
            logic.endGame();
        }
        else if (collision.gameObject.layer == 8 && logic.getActive()) {
            Debug.Log("Enemy hit by Anchor");
            Destroy(gameObject);
        }
    } */
}
