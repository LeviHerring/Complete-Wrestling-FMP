using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLISIOn!");

        if (collision.gameObject.name == "Neutral")
        {
            Debug.Log("I was hit by Neutral");
        }
        if (collision.gameObject.name == "Special")
        {
            Debug.Log("I was hit by SPECIAL");
        }
        if (collision.gameObject.name == "Strong")
        {
            Debug.Log("I was hit by STRONGSTRONGSTRONG");
        }
        if (collision.gameObject.tag == "RopesRight")
        {
            rb.velocity = new Vector2(-50f, 0f);

        }
        if (collision.gameObject.tag == "RopesLeft")
        {
            rb.velocity = new Vector2(50f, 0f);

        }
        if (collision.gameObject.tag == "RopesUp")
        {
            rb.velocity = new Vector2(0f, -5f);

        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RopesRight")
        {
            rb.velocity = new Vector2(-10f, 0f);

        }
        if (collision.gameObject.tag == "RopesLeft")
        {
            rb.velocity = new Vector2(10f, 0f);

        }
        if (collision.gameObject.tag == "RopesUp")
        {
            rb.velocity = new Vector2(0f, -10f);

        }
    }
}
