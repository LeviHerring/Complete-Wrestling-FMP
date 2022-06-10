using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    Powerups powerups;
    public GameObject pickupEffect;
    public GameObject player;
    //public GameObject player2;
    //public GameObject player3;
    //public GameObject player4;
    //public GameObject playerDamage;
    //public GameObject playerDamage2;
    //public GameObject playerDamage3;
    //public GameObject playerDamage4;
    DamageManager damageManager;

    // Start is called before the first frame update
    void Start()
    {
        powerups = GetComponent<Powerups>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == player.gameObject.name)
        {
            StartCoroutine(PickupPlayer1());
        }
        //if (collision.gameObject.name == player2.gameObject.name)
        //{
        //    StartCoroutine(PickupPlayer2());
        //}
        //if (collision.gameObject.name == player3.gameObject.name)
        //{
        //    StartCoroutine(PickupPlayer3());
        //}
        //if (collision.gameObject.name == player4.gameObject.name)
        //{
        //    StartCoroutine(PickupPlayer4());
        //}
    }

    public IEnumerator PickupPlayer1()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        pickupEffect.gameObject.SetActive(true);

        Debug.Log("Picked Up!");
        player.GetComponent<Health>().health -= 10;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(2f);
        pickupEffect.gameObject.SetActive(false);

        yield return new WaitForSeconds(3f);
        //GetComponent<Hitbox>().damageAmount = GetComponent<Hitbox>().damageAmount * 3; 
        Debug.Log("UNUNUNUNUPicked Up!");

        Destroy(gameObject);
    }
    //public IEnumerator PickupPlayer2()
    //{
    //    Instantiate(pickupEffect, transform.position, transform.rotation);
    //    pickupEffect.gameObject.SetActive(true);

    //    Debug.Log("Picked Up!");
    //    player2.GetComponent<Health>().health -= 10;

    //    GetComponent<SpriteRenderer>().enabled = false;
    //    GetComponent<Collider2D>().enabled = false;

    //    yield return new WaitForSeconds(0.2f);
    //    pickupEffect.gameObject.SetActive(false);

    //    yield return new WaitForSeconds(3f);
    //    //GetComponent<Hitbox>().damageAmount = GetComponent<Hitbox>().damageAmount * 3; 
    //    Debug.Log("UNUNUNUNUPicked Up!");

    //    Destroy(gameObject);
    //}
    //public IEnumerator PickupPlayer3()
    //{
    //    Instantiate(pickupEffect, transform.position, transform.rotation);
    //    pickupEffect.gameObject.SetActive(true);

    //    Debug.Log("Picked Up!");
    //    player3..GetComponent<Health>().health -= 10;

    //    GetComponent<SpriteRenderer>().enabled = false;
    //    GetComponent<Collider2D>().enabled = false;

    //    yield return new WaitForSeconds(0.2f);
    //    pickupEffect.gameObject.SetActive(false);

    //    yield return new WaitForSeconds(3f);
    //    //GetComponent<Hitbox>().damageAmount = GetComponent<Hitbox>().damageAmount * 3; 
    //    Debug.Log("UNUNUNUNUPicked Up!");

    //    Destroy(gameObject);
    //}
    //public IEnumerator PickupPlayer4()
    //{
    //    Instantiate(pickupEffect, transform.position, transform.rotation);
    //    pickupEffect.gameObject.SetActive(true);

    //    Debug.Log("Picked Up!");
    //    player4.GetComponent<Health>().health -= 10;

    //    GetComponent<SpriteRenderer>().enabled = false;
    //    GetComponent<Collider2D>().enabled = false;

    //    yield return new WaitForSeconds(0.2f);
    //    pickupEffect.gameObject.SetActive(false);

    //    yield return new WaitForSeconds(3f);
    //    //GetComponent<Hitbox>().damageAmount = GetComponent<Hitbox>().damageAmount * 3; 
    //    Debug.Log("UNUNUNUNUPicked Up!");

    //    Destroy(gameObject);
    //}

}
