using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class MainSceneMultiplayerAwake : MonoBehaviour
{
    public GameObject greenSquare;
    public GameObject redCircle;
    public GameObject astronaut; 
    public GameObject narbyDallin; 
    public Transform playerOneSpawn;
    public Transform playerTwoSpawn; 
    PlayerInputManager playerInputManager;
    public int playerCount = 1; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        playerInputManager = GetComponent<PlayerInputManager>();
        string player1 = PlayerPrefs.GetString("playerOne");
        
        switch (player1)
        {
            case "RedCircle":
                playerInputManager.playerPrefab = redCircle;
                redCircle.transform.position = playerOneSpawn.position; 
                Debug.Log("PLAYER 1 RED CIRCLE");
                break;
            case "GreenSquare":
                playerInputManager.playerPrefab = greenSquare;
                greenSquare.transform.position = playerOneSpawn.position;
                Debug.Log("PLAYER 1 Green Square");
                break;
            case "Astronaut":
                playerInputManager.playerPrefab = astronaut;
                astronaut.transform.position = playerOneSpawn.position;
                break;
            case "NarbyDallin":
                playerInputManager.playerPrefab = narbyDallin;
                narbyDallin.transform.position = playerOneSpawn.position;
                break;
        }
    }
    //void OnPlayerJoined(PlayerInput playerInput)
    //{
    //    Debug.Log("Player joined the game - Hello!");
    //    string player2 = PlayerPrefs.GetString("playerTwo");
    //    switch (player2)
    //    {
    //        case "RedCircle":
    //            playerInputManager.playerPrefab = redCircle;
    //            redCircle.transform.position = playerTwoSpawn.position;
    //            Debug.Log("PLAYER 2 RED CIRCLE");
    //            break;
    //        case "GreenSquare":
    //            playerInputManager.playerPrefab = greenSquare;
    //            greenSquare.transform.position = playerTwoSpawn.position;
    //            Debug.Log("PLAYER 2 Green Square");
    //            break;
    //            //case "PlayerThree":
    //            //    Instantiate(playerThree, spawnPosition.transform.position, Quaternion.identity);
    //            //    break;
    //            //case "PlayerFour":
    //            //    Instantiate(playerFour, spawnPosition.transform.position, Quaternion.identity);
    //            //    break;
    //    }

    //}
}
