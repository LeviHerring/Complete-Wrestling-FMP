using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction; 

public class TwoPlayerManagerCharacterSelectScreen : MonoBehaviour
{
    private PlayerInput playerInput; 
    public GameObject playerOne;
    public GameObject playerTwo;
    public GlobalMultiplayerVariables globalMultiplayerVariables;
    public GameObject spawnPositionOne; 
    public GameObject spawnPositionTwo;
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        if(globalMultiplayerVariables.playerIndex == 1)
        {
            Instantiate(playerOne, spawnPositionOne.transform.position, Quaternion.identity/*, gameObject.transform*/);
            globalMultiplayerVariables.playerIndex++; 
        }
        else
        {
            Instantiate(playerTwo, spawnPositionTwo.transform.position, Quaternion.identity/*, gameObject.transform*/);
            globalMultiplayerVariables.playerIndex = 1;
        }
        Destroy(gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Pressed EAST BACK"); 
        }
    }
}
