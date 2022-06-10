using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class InputDeviceAssignment : MonoBehaviour
{
    public InputActionAsset inputActionAssetPlayerOne; 
    public InputActionAsset inputActionAssetPlayerTwo; 
    PlayerInput playerInput;
    CharacterSelectScreenController characterSelectScreenController; 
    // Start is called before the first frame update
    void Start()
    {
        characterSelectScreenController = GetComponent<CharacterSelectScreenController>(); 
        playerInput = GetComponent<PlayerInput>();
        if(characterSelectScreenController.playerNo == 1)
        {
            playerInput.actions = inputActionAssetPlayerOne;
        }
        else
        {
            playerInput.actions = inputActionAssetPlayerTwo;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
