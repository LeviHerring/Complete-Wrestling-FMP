using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{

    public GameObject pickupEffect;
    Hitbox hitbox;
    Health health;
    GameObject player; 


    public void Start()
    {
        hitbox = GetComponent<Hitbox>();
        health = GetComponent<Health>(); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(Pickup());
        }
    }

     public IEnumerator Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        pickupEffect.gameObject.SetActive(true);

        Debug.Log("Picked Up!");
        //GetComponent<Health>().health = GetComponent<Health>().health - 20; 

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(0.2f); 
        pickupEffect.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);
        //GetComponent<Hitbox>().damageAmount = GetComponent<Hitbox>().damageAmount * 3; 
        Debug.Log("UNUNUNUNUPicked Up!");
        
        Destroy(gameObject);
    }
}
