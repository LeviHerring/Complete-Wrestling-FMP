using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction; 

public class PlayerInputHandleUnInitialised : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMovementFinal playerMovement; 

    // Start is called before the first frame update
    void Start()
    {
        //playerInput = GetComponent<PlayerInput>();
        //var playerMovementFinals = FindObjectOfType<PlayerMovementFinal>(); 
        //var index = playerInput.playerIndex;
        //playerMovementFinals = playerMovementFinals.FirstOrDefault(mbox => m.GetPlayerIndex() == index); 
        //playerMovement = GetComponent<PlayerMovementFinal>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
