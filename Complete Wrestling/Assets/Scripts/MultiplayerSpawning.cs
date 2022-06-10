using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class MultiplayerSpawning : MonoBehaviour
{
    PlayerInputManager playerInput;
    public GameObject greenSquare;
    public GameObject redCircle;
    Transform playerOneSpawn;
    Transform playerTwoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInputManager>();
        string player1 = PlayerPrefs.GetString("playerOne");
        string player2 = PlayerPrefs.GetString("playerTwo");
        PlayerOne(player1);
        PlayerTwo(player2);



    }

    private void Awake()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerOne(string player1)
    {
        
        

        switch (player1)
        {
            case "RedCircle":
                //playerInput.playerPrefab = redCircle;
                PlayerInputManager.instance.JoinPlayer(0, -1, null);
                Debug.Log("PLAYER 1 RED CIRCLE");
                break;
            case "GreenSquare":
                //playerInput.playerPrefab = greenSquare;
                PlayerInputManager.instance.JoinPlayer(0, -1, null);
                Debug.Log("PLAYER 1 Green Square");
                break;
                //case "PlayerThree":
                //    Instantiate(playerThree, spawnPosition.transform.position, Quaternion.identity);
                //    break;
                //case "PlayerFour":
                //    Instantiate(playerFour, spawnPosition.transform.position, Quaternion.identity);
                //    break;
        }
    }

    public void PlayerTwo(string player2)
    {
        Debug.Log("Entered Function");
        switch (player2)
        {
            case "RedCircle":
                //playerInput.playerPrefab = redCircle;
                PlayerInputManager.instance.JoinPlayer(1, 1, null);
                Debug.Log("Spawned player 2 as red circle");
                break;
            case "GreenSquare":
                //playerInput.playerPrefab = greenSquare;
                PlayerInputManager.instance.JoinPlayer(1, 1, null);
                Debug.Log("Spawned player 2 as green square"); 
                break;
                //case "PlayerThree":
                //    Instantiate(playerThree, spawnPosition.transform.position, Quaternion.identity);
                //    break;
                //case "PlayerFour":
                //    Instantiate(playerFour, spawnPosition.transform.position, Quaternion.identity);
                //    break;
        }
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Debug.Log("Player joined the game - Hello!");
    }

}
