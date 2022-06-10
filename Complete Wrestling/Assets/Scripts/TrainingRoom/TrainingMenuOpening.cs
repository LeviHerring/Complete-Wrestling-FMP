using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; 

public class TrainingMenuOpening : MonoBehaviour
{
    public PlayerInput playerInput;
    public GameObject panel;
    PlayerMovementFinal playerMovement;
    Animator animator;
    AnimationEvents animationEvents;
    bool pressed; 

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovementFinal>();
        animator = GetComponent<Animator>();
        animationEvents = GetComponent<AnimationEvents>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuOpening(InputAction.CallbackContext context)
    {
        if(context.performed && pressed == false)
        {
            panel.gameObject.SetActive(true);
            animationEvents.isAttacking = true;
            pressed = true; 
        }
        else if (context.performed && pressed == true)
        {
            panel.gameObject.SetActive(false);
            animationEvents.isAttacking = false;
            pressed = false; 
        }
    }
}
