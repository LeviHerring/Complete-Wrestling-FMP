using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using System.Diagnostics;
using System.Threading;

public class NarbyDallinAttack : MonoBehaviour
{

    //public Stopwatch timer;

    PlayerMovementFinal PlayerMovementFinal;
    AnimationEvents animationEvents;
    public DamageManager damageManager;
    public GameObject detector;
    Animator animator; 

    public NarbyDallinHitbox darbyHitbox;
    public bool isActivatedHere;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovementFinal = GetComponent<PlayerMovementFinal>();
        animationEvents = GetComponent<AnimationEvents>();
        darbyHitbox.stopwatch = 0;
        animator = GetComponent<Animator>(); 

    }

    // Update is called once per frame
    void Update()
    {
        darbyHitbox.stopwatch -= Time.deltaTime;

        if (darbyHitbox.stopwatch <= 0f)
        {
            damageManager.damageMultiplier = damageManager.damageMultiplier - 5;
            darbyHitbox.isActivated = false;
            isActivatedHere = false;
            if (damageManager.damageMultiplier <= 1)
            {
                damageManager.damageMultiplier = 1;
            }
        }
    }

    public void PictureInPicture(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            animationEvents.isAttacking = true;
            detector.SetActive(true);

        }
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                UnityEngine.Debug.Log("Performed");
                animator.SetBool("isSpecial", true);
                animator.SetBool("isDown", true);

                break;
            case InputActionPhase.Started:
                UnityEngine.Debug.Log("Started");
                break;
            case InputActionPhase.Canceled:
                UnityEngine.Debug.Log("Cancelled");
                animator.SetBool("isSpecial", false);
                animator.SetBool("isDown", false);
                animationEvents.isAttacking = false; 
         
                //DamageMultiplier();
                damageManager.damageMultiplier += 5;
                break;
        }


    }

    public void DamageMultiplier()
    {
        if (darbyHitbox.isActivated == true)
        {
            isActivatedHere = true;
            if (isActivatedHere == true)
            {

                if (darbyHitbox.stopwatch <= 5f || darbyHitbox.stopwatch > 0f)
                {
                    damageManager.damageMultiplier += 5;
                }
                else if (darbyHitbox.stopwatch <= 0f)
                {
                    damageManager.damageMultiplier = damageManager.damageMultiplier - 5;
                    darbyHitbox.isActivated = false;
                    isActivatedHere = false;
                    Debug.Log("Less than 0"); 
                }
                else
                {
                    damageManager.damageMultiplier -= 5;
                    darbyHitbox.isActivated = false;
                    isActivatedHere = false;
                }
            }
            if (isActivatedHere == false)
            {
                damageManager.damageMultiplier -= 5;
            }

            //}
            //if(darbyHitbox.isActivated == false)
            //{
            //    dm.damageMultiplier -= 5;
            //}

            //if(darbyHitbox.isActivated == true)
            //{
            //    isActivatedHere = true;
            //    if (isActivatedHere == true)
            //    {
            //        Stopwatch stopwatch = new Stopwatch();
            //        stopwatch.Start();
            //        dm.damageMultiplier += 5;
            //        Thread.Sleep(5000);
            //        stopwatch.Stop();
            //        dm.damageMultiplier -= 5;
            //        darbyHitbox.isActivated = false;
            //        isActivatedHere = false; 
            //        UnityEngine.Debug.Log(stopwatch.Elapsed); 

            //    }
            //}
        }





    }
}




