using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockback : MonoBehaviour
{
    PlayerMovementFinal playerMovement;
    FacingDirection facingDirection;
    Rigidbody2D rigidbody2d;
    //public Hitbox hitbox; 

    //[SerializeField] float knockbackLength = 0.01f;
    //[SerializeField] float knockbackForce = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        facingDirection = GetComponent<FacingDirection>();
        playerMovement = GetComponent<PlayerMovementFinal>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void DoKnockBack(/*float knockbackLength,*/ Vector2 knockback /*float hitHorizontal, float hitVertical*/)
    {
        //StartCoroutine(DisablePlayerMovement(/*knockbackLength*/)); 
        rigidbody2d.velocity = knockback;
        //playerMovement.hitHorizontal = hitHorizontal;
        //playerMovement.hitVertical = hitVertical;

    }

    //IEnumerator DisablePlayerMovement(/*float time*/)
    //{
    //    animationEvents.isAttacking = true;

    //    yield return new WaitForSeconds(0.5f);
    //    animationEvents.isAttacking = false;
    //}

}
