using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    PlayerMovementFinal playerMovementFinal;

    [SerializeField] float timeToDestroy = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        playerMovementFinal = GetComponent<PlayerMovementFinal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartShoot(bool isFacingRight)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>(); 

       if (isFacingRight == false)
            {


                rb.velocity = new Vector2(-3, 0);
            }
            else
            {

                rb.velocity = new Vector2(3, 0);
            }

            Destroy(gameObject, timeToDestroy);

    }
}
