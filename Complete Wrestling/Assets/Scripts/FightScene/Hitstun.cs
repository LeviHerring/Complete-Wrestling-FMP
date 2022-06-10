using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitstun : MonoBehaviour
{

    AnimationEvents animationEvents;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        animationEvents = GetComponent<AnimationEvents>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hitbox")
        {
            Debug.Log("Hit"); 
            StartCoroutine(DisablePlayerMovement(0.5f)); 
        }
    }

    IEnumerator DisablePlayerMovement(float time)
    {
        Debug.Log("In the coroutine"); 
        //animator.SetBool("IsHit", true);
        animationEvents.isAttacking = true;
        rigidbody2D.velocity = new Vector2(10f, 0); 
        yield return new WaitForSeconds(time);
        animationEvents.isAttacking = false;
    }
}
