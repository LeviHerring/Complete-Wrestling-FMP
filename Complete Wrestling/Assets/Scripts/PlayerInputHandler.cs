using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerInputHandler : MonoBehaviour
{

    private PlayerConfiguration playerConfig;
    // Start is called before the first frame update

    [SerializeField] private GameObject character;

    private PlayerMovementFinal playerMovementFinal;

    private Controls controls; 
    void Start()
    {
        
    }
    private void Awake()
    {
        controls = new Controls();
        var playerMovement = GetComponent<PlayerMovementFinal>(); 
    }

    public void InitialisePlayer(PlayerConfiguration playerConfiguration)
    {
        playerConfig = playerConfiguration;
        character = playerConfiguration.playerCharacter;
        playerConfig.Input.onActionTriggered += Input_onActionTriggered;
    }

    private void Input_onActionTriggered(InputAction.CallbackContext obj)
    {
        //if (obj.action.name == controls)
        //{

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
