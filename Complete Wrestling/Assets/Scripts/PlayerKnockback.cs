using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnockback : MonoBehaviour
{
    AnimationEvents animationEvents; 
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
        animationEvents = GetComponent<AnimationEvents>(); 
    }

    public void DoKnockBack(/*float knockbackLength,*/ Vector2 knockback /*float hitHorizontal, float hitVertical*/)
    {
        //StartCoroutine(DisablePlayerMovement(/*knockbackLength*/)); 
        animationEvents.isAttacking = true;
        playerMovement.knockback = knockback; 
        rigidbody2d.velocity = playerMovement.knockback;
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
