using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorMover : MonoBehaviour
{
   // float speed = 5;
    float outOfBounds = -15;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += (Vector3.down  * speed) * Time.deltaTime;
        /*
        if (transform.position.y > outOfBounds) {
            Debug.Log("Anchor Deleted");
            Destroy(gameObject);
        } */

        
    }

/*
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("OnCollisonEnter2D - AnchorMover");
        if (collision.gameObject.layer == 3) {
            logic.endGame();
            Debug.Log("Hit by Anchor, Deleted");
            //Destroy(gameObject);
        }
        else {
            Debug.Log("Anchor collision no diver");
        }
    } */
}
