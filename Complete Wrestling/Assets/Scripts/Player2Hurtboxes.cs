using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem; 

public class Player2Hurtboxes : MonoBehaviour
{
    public Animator animator;
    public AnimationEvents animationEvents;
    public bool isHit;
    public float stopwatch;
    public float stopwatchTime;
    public float disabledTime;
    public GloablVariablesManager globalVariablesManager;
    public bool hasWon;
    public bool isMashingNeeded;
    public float fillAmount;
    public Image metre;
    public int mashingAmountNeeded;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch = Time.deltaTime;

        if (stopwatch <= 0 && isHit == true)
        {
            isHit = false;
            //animationEvents.isAttacking = false; 
            Debug.Log("Attacking is false");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hitbox")
        {
            //StartCoroutine(DisablePlayerMovement(disabledTime));


        }

        if (collision.gameObject.tag == "Pin")
        {
            animationEvents.isAttacking = true;
            isMashingNeeded = true;
        }
    }


    public void Mashing(InputAction.CallbackContext context)
    {
        if (isMashingNeeded == true)
        {
            if (context.performed)
            {
                globalVariablesManager.player2MashingDone++;
                fillAmount = globalVariablesManager.player2MashingDone / 10;
                metre.fillAmount = fillAmount;


            }
            if (globalVariablesManager.player2MashingDone == mashingAmountNeeded)
            {
                hasWon = true;
                isMashingNeeded = false; 
            }
        }

    }


    IEnumerator DisablePlayerMovement(float time)
    {
        animator.SetBool("IsHit", true);
        animationEvents.isAttacking = true;

        yield return new WaitForSeconds(time);
        animationEvents.isAttacking = false;
    }
}
