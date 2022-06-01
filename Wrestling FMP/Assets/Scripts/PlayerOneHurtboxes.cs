using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement; 

public class PlayerOneHurtboxes : MonoBehaviour
{

    Text mashingAmountText;
     public GameObject player;
    public GameObject enemy; 
     public Animator animator;
     AnimationEvents animationEvents;
     public Rigidbody2D rigidbody2d; 
    public bool isHit;
    public float stopwatch;
    public float stopwatchTime;
    public float disabledTime;
     GloablVariablesManager globalVariables;
     PlayerMovementFinal playerMovement;
     Health health; 
    public bool hasWon;
    public bool hasWonSubmit;
    public bool isMashingNeeded;
    public float fillAmount;
     Image metre;
    public float mashingAmountNeeded;
    public int countdownTime;
    public float randomSubmit;
    public float submissionNo; 
     Text countdownDisplay;
    int loopNumber = 0;
    string playerString;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody2d = GetComponent<Rigidbody2D>(); 
        //animator = player.GetComponent<Animator>();
        animationEvents = player.GetComponent<AnimationEvents>();
        //rigidbody2d = player.GetComponent<Rigidbody2D>();
        playerMovement = player.GetComponent<PlayerMovementFinal>(); 
        health = player.GetComponent<Health>();
        globalVariables = FindObjectOfType<GloablVariablesManager>();
        if (player.GetComponent<PlayerAttachedMultiplayer>().playerNo == 1)
        {
            mashingAmountText = ComponentManager.instance.player1MashingNeededText;
            metre = ComponentManager.instance.player1MashingMetre;
            countdownDisplay = ComponentManager.instance.player1Countdown;
            enemy = GameObject.FindGameObjectWithTag("PlayerTwo");
            playerString = "PlayerTwo"; 
        }
        else
        {
            mashingAmountText = ComponentManager.instance.player2MashingNeededText;
            metre = ComponentManager.instance.player2MashingMetre;
            countdownDisplay = ComponentManager.instance.player2Countdown;
            enemy = GameObject.FindGameObjectWithTag("PlayerOne");
            playerString = "PlayerOne";
        }
        mashingAmountNeeded = 1; 
    }

    // Update is called once per frame
    void Update()
    {

        stopwatch = Time.deltaTime; 

        if(stopwatch <= 0 && isHit == true)
        {
            isHit = false;

            //animationEvents.isAttacking = false; 
            Debug.Log("Attacking is false");
            loopNumber = 0; 
        }

        if(isHit == true)
        {
            while(loopNumber == 0)
            {
                  globalVariables.maxrange -= health.health;
                  mashingAmountNeeded += health.health;
                 loopNumber++; 
            }
          
        }

        if(enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag(playerString); 
        }

        if(hasWon == true)
        {
            StartCoroutine(HasWon()); 
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hitbox")
        {
            disabledTime = collision.gameObject.GetComponent<Hitbox>().hitstun; 
            StartCoroutine(DisablePlayerMovement(disabledTime));


        }

        if(collision.gameObject.tag == "Pin")
        {
            mashingAmountText.text = globalVariables.player1MashingDone + "/" + mashingAmountNeeded; 
            mashingAmountText.gameObject.SetActive(true); 
            animationEvents.isAttacking = true;
            enemy.GetComponent<AnimationEvents>().isAttacking = true; 
            isMashingNeeded = true;
            StartCoroutine(CountdownToStart(3));
        }
        if(collision.gameObject.tag == "Submission")
        {
            animationEvents.isAttacking = true;
            randomSubmit = Random.Range(1f, globalVariables.maxrange); 
            submissionNo = Random.Range(1f, globalVariables.maxrange);
            if (submissionNo == randomSubmit)
            {
                Debug.Log("Submitted");
                hasWonSubmit = false;
                SceneManager.LoadScene(playerString + "Wins"); 
                //go to gave overscreen!!!
            }
            else
            {
              Debug.Log("DON'T SUBMIT");
                KnockBack();
                hasWonSubmit = true; 
            }
        }

        if (collision.gameObject.tag == "RopesRight")
        {
            Debug.Log("Hit Right");
            playerMovement.isHit = true;
            playerMovement.knockback = new Vector2(10f, 0f);
            playerMovement.isHit = false;
        }
        if (collision.gameObject.tag == "RopesLeft")
        {
            playerMovement.isHit = true;
            playerMovement.knockback = new Vector2(-10f, 0f);
            playerMovement.isHit = false;
            Debug.Log("Hit Left");
        }
        if (collision.gameObject.tag == "RopesUp")
        {
            playerMovement.isHit = true;
            playerMovement.knockback = new Vector2(0f, -7f);
            playerMovement.isHit = false;
        }
    }


    public void Mashing(InputAction.CallbackContext context)
    {
        if (isMashingNeeded == true)
        {
            if (context.performed)
            {
                globalVariables.player1MashingDone++;
                fillAmount = globalVariables.player1MashingDone / 10;
                metre.fillAmount = fillAmount;


            }
            if (globalVariables.player1MashingDone == mashingAmountNeeded)
            {
                hasWon = true;
                isMashingNeeded = false; 
            }
        }
        if(isMashingNeeded && context.performed)
        {
            globalVariables.player1MashingDone++;
            fillAmount = globalVariables.player1MashingDone / 10;
            metre.fillAmount = fillAmount;

            if(globalVariables.player1MashingDone == mashingAmountNeeded)
            {
                hasWon = true;
                isMashingNeeded = false;
            }
        }

    }

    public IEnumerator CountdownToStart(int countdownTime2)
    {
        countdownDisplay.gameObject.SetActive(true); 

        while (countdownTime2 > 0 && hasWon == false)
        {
            //if (/*pinningButtonMash.hasWon == true &&*/ countdownTime2 > 0)
            //{
            //    countdownDisplay.text = "Pin broken!";
            //}
            //else
            //{
            countdownDisplay.text = countdownTime2.ToString();
            animationEvents.isAttacking = true;
            enemy.GetComponent<AnimationEvents>().isAttacking = true;
            yield return new WaitForSeconds(1f);

            countdownTime2--;
            //}
            if (hasWon == true)
            {
                Debug.Log("Entered The first if"); 
                countdownDisplay.text = "Pin broken!";
                yield return new WaitForSeconds(1f);
                countdownDisplay.gameObject.SetActive(false);
                mashingAmountText.gameObject.SetActive(false);
                hasWon = false;
            }
            

        }
        if (hasWon == true)
        {
            countdownDisplay.text = "Pin broken!";
            yield return new WaitForSeconds(1f);
            countdownDisplay.gameObject.SetActive(false);
            hasWon = false; 
        }
        else 
        {
            countdownDisplay.text = "Pinned!";

            yield return new WaitForSeconds(1f);
            countdownDisplay.gameObject.SetActive(false);
            SceneManager.LoadScene(playerString + "Wins");

        }

       
    }
    IEnumerator DisablePlayerMovement(float time)
    {
        animator.SetBool("IsHit", true);
        animationEvents.isAttacking = true;
        playerMovement.isHit = true; 

        yield return new WaitForSeconds(time);
        animationEvents.isAttacking = false;
        playerMovement.isHit = false;
        animator.SetBool("IsHit", false);
    }

    public void KnockBack()
    {
        if (playerMovement.isFacingRight == true)
        {
            rigidbody2d.velocity = new Vector2(5, 5);
            animationEvents.isAttacking = false; 
        }
        else
        {
            rigidbody2d.velocity = new Vector2(-5, -5);
            animationEvents.isAttacking = false;
        }
    }

    public IEnumerator HasWon()
    {
        countdownDisplay.text = "Pin broken!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        animationEvents.isAttacking = false;
        enemy.GetComponent<AnimationEvents>().isAttacking = false;
        hasWon = false;
    }

    public void SubmissionNumberChanger()
    {

    }


}
