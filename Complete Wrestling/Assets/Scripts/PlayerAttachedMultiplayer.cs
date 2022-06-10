using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI; 

public class PlayerAttachedMultiplayer : MonoBehaviour
{
    TextMeshProUGUI playerJoinText;
    public GameObject redCircle;
    public GameObject greenSquare;
    public GameObject astronaut;
    public GameObject narbyDallin;
    public int playerNo; 
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
        string player2 = PlayerPrefs.GetString("playerTwo");
        switch (player2)
        {
            case "RedCircle":
                FindObjectOfType<PlayerInputManager>().playerPrefab = redCircle;
                Debug.Log("Spawned player 2 as red circle");
                break;
            case "GreenSquare":
                FindObjectOfType<PlayerInputManager>().playerPrefab = greenSquare;
                Debug.Log("Spawned player 2 as green square");
                break;
            case "Astronaut":
                FindObjectOfType<PlayerInputManager>().playerPrefab = astronaut;
                break;
            case "NarbyDallin":
                FindObjectOfType<PlayerInputManager>().playerPrefab = narbyDallin;
                break;
        }

        FindObjectOfType<GloablVariablesManager>().playersJoined++;

        if (FindObjectOfType<GloablVariablesManager>().playersJoined == 1)
        {
            playerNo = 1;
            gameObject.tag = "PlayerOne";
            gameObject.name = "PlayerOne"; 
            gameObject.transform.position = FindObjectOfType<GloablVariablesManager>().playerOneSpawn.transform.position;
            playerJoinText = ComponentManager.instance.playerJoin;
            playerJoinText.text = "Player 2 press button to join";

        }
        else
        {
            playerNo = 2;
            gameObject.tag = "PlayerTwo";
            gameObject.name = "PlayerTwo";
            gameObject.transform.position = FindObjectOfType<GloablVariablesManager>().playerTwoSpawn.transform.position;
            playerJoinText = ComponentManager.instance.playerJoin; 
            playerJoinText.gameObject.SetActive(false);
            FindObjectOfType<GloablVariablesManager>().realPlayerNumber = 2;
        }

    }
}
