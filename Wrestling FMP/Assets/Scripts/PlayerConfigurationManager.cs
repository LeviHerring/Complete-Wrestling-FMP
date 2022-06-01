using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; 

public class PlayerConfigurationManager : MonoBehaviour
{
    private List<PlayerConfiguration> playerConfigs;

    [SerializeField] private int maxPlayers = 2;

    public static PlayerConfigurationManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("Singleton = trying to create another instance of Singleton!!");
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
            playerConfigs = new List<PlayerConfiguration>(); 
        }
    }

    public void SetPlayerColour(int index, GameObject characterPrefab)
    {
        playerConfigs[index].playerCharacter = characterPrefab; 
    }

    public void ReadyPlayer(int index)
    {
        playerConfigs[index].isReady = true;
        if (playerConfigs.Count == maxPlayers && playerConfigs.All(p => p.isReady == true))
        {
            SceneManager.LoadScene("SampleScene"); 
        }
    }

    public void HandlePlayerJoin(PlayerInput playerInput)
    {
        Debug.Log("Player Joined" + playerInput.playerIndex);
        playerInput.transform.SetParent(transform);
        if(!playerConfigs.Any(p => p.PlayerIndex == playerInput.playerIndex))
        {
            playerInput.transform.SetParent(transform);
            playerConfigs.Add(new PlayerConfiguration(playerInput)); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressingAButton(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("south button pressed");
        }
    }
}

public class PlayerConfiguration
{
    public PlayerConfiguration(PlayerInput playerInput)
    {
        PlayerIndex = playerInput.playerIndex;
        Input = playerInput; 
    }
    public PlayerInput Input { get; set; }

    public int PlayerIndex { get; set; }

    public bool isReady { get; set; }
    
    public GameObject playerCharacter { get; set; }
}