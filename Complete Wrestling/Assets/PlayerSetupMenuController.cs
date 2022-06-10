using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerSetupMenuController : MonoBehaviour
{
    private int playerIndex;

    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private GameObject readyPanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private Button readyButton; 

    private float ignoreInputTime = 1.3f;
    private bool inputEnabled; 

    public void SetPlayerIndex(int playerInput)
    {
        playerIndex = playerInput;
        titleText.SetText("Player" + (playerInput + 1).ToString());
        ignoreInputTime = Time.time + ignoreInputTime; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > ignoreInputTime)
        {
            inputEnabled = true;
        }
    }

    public void SetCharacter(GameObject characterPrefab)
    {
        if(!inputEnabled) { return; }

        PlayerConfigurationManager.Instance.SetPlayerColour(playerIndex, characterPrefab);
        readyPanel.SetActive(true);
        readyButton.Select();
        menuPanel.SetActive(false); 
    }

    public void ReadyPlayer()
    {
        if(!inputEnabled) { return; }
        PlayerConfigurationManager.Instance.ReadyPlayer(playerIndex);
        readyButton.gameObject.SetActive(false);
    }
}
