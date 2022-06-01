using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class MainSceneInputAssigner : MonoBehaviour
{
    public InputActionAsset inputActionAssetPlayerOne;
    public InputActionAsset inputActionAssetPlayerTwo;
    PlayerInput playerInput;
    PlayerAttachedMultiplayer playerAttachedMultiplayer; 
    // Start is called before the first frame update
    void Start()
    {
        playerAttachedMultiplayer = GetComponent<PlayerAttachedMultiplayer>();
        playerInput = GetComponent<PlayerInput>();
        if (playerAttachedMultiplayer.playerNo == 1)
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
