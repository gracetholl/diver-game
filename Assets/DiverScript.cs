using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverScript : MonoBehaviour
{
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.05f, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(0.05f, 0, 0);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("COLLISION WITH DIVER");
        if (collision.gameObject.layer > 6 && logic.getActive()) {
            Debug.Log("DIVER Hit Enemy; END");
            logic.endGame();
        }

        
    } 
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("TRIGGER COLLISION WITH DIVER");
        if (collision.gameObject.layer > 6  && logic.getActive()) {
            Debug.Log("DIVER Hit Enemy");
            logic.endGame();
        }
        else {
            Debug.Log(collision.gameObject.layer);
        }
    } 
}
