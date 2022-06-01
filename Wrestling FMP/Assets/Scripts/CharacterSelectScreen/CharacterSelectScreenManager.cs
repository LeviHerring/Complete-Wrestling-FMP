using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class CharacterSelectScreenManager : MonoBehaviour
{
     GameObject playerOne;
     GameObject playerTwo;
    public GameObject panel;
    public Text items;
    public Text powerups;
    public Text hazards;
    public bool isItemsOn;
    public bool isPowerupsOn;
    public bool isHazardsOn; 

    // Start is called before the first frame update
    void Start()
    {
        isItemsOn = false;
        isPowerupsOn = false;
        isHazardsOn = false; 
    }

    private void Awake()
    {
        //playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        //playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
        string powerupsText = PlayerPrefs.GetString("powerups");
        string hazardsText = PlayerPrefs.GetString("hazards");
        string itemsText = PlayerPrefs.GetString("items"); 

        if(powerupsText == "true")
        {
            powerups.text = "powerups: On";
        }
        else
        {
            powerups.text = "powerups: off";
        }

        if(hazardsText == "true")
        {
            hazards.text = "hazards: On";
        }
        else
        {
            hazards.text = "hazards: off";
        }

        if(itemsText == "true")
        {
            items.text = "items: On";
        }
        else
        {
            items.text = "items: off";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerOne == null)
        {
            playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
            //playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
        }
        if (playerTwo == null)
        {
            //playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
            playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
        }


        if (playerOne.GetComponent<CharacterSelectScreenController>().isSelected == true && playerTwo.GetComponent<CharacterSelectScreenController>().isSelected == true)
        {
            panel.SetActive(true); 
        }




    }

    public void StartButton()
    {
        switch (playerOne.GetComponent<CharacterSelectScreenController>().position)
        {
            case 0:
                PlayerPrefs.SetString("playerOne", "Astronaut");
                Debug.Log("Player 1 selected Astronaut");
                break;

            case 1:
                PlayerPrefs.SetString("playerOne", "RedCircle");
                Debug.Log("Player 1 selected RedCirlce");
                break;

            case 2:
                PlayerPrefs.SetString("playerOne", "GreenSquare");
                Debug.Log("Player 1 selected Green Square");
                break;

            case 3:
                PlayerPrefs.SetString("playerOne", "NarbyDallin");
                Debug.Log("Player 1 selected NarbyDallin");
                break;
        }
        switch (playerTwo.GetComponent<CharacterSelectScreenController>().position)
        {
            case 0:
                PlayerPrefs.SetString("playerTwo", "Astronaut");
                Debug.Log("Player 2 selected Astronaut");
                break;

            case 1:
                PlayerPrefs.SetString("playerTwo", "RedCircle");
                Debug.Log("Player 2 selected Red circle");
                break;

            case 2:
                PlayerPrefs.SetString("playerTwo", "Greensquare");
                Debug.Log("Player 2 selected Green Square");
                break;

            case 3:
                PlayerPrefs.SetString("playerOne", "NarbyDallin");
                Debug.Log("Player 2 selected Skeleton");
                break;
        }
        SceneManager.LoadScene("SampleScene");
    }

    public void BackButton()
    {
        playerOne.GetComponent<SpriteRenderer>().enabled = true;
        playerTwo.GetComponent<SpriteRenderer>().enabled = true;
        playerOne.GetComponent<CharacterSelectScreenController>().isSelected = false;
        playerTwo.GetComponent<CharacterSelectScreenController>().isSelected = false;
        panel.gameObject.SetActive(false); 
    }

    public void StaminaMode()
    {
        SceneManager.LoadScene("StaminaMode"); 
    }

    public void Items()
    {
        if(isItemsOn == false)
        {
            items.text = "Items: On";
            isItemsOn = true;
            PlayerPrefs.SetString("items", "true"); 
        }
        else
        {
            items.text = "Items: Off";
            isItemsOn = false;
            PlayerPrefs.SetString("items", "false");
        }
    }

    public void Powerups()
    {
        if (isPowerupsOn == false)
        {
            powerups.text = "powerups: On";
            isPowerupsOn = true;
            PlayerPrefs.SetString("powerups", "true");
        }
        else
        {
            powerups.text = "powerups: Off";
            isPowerupsOn = false;
            PlayerPrefs.SetString("powerups", "false");
        }
    }

    public void Hazards()
    {
        if (isHazardsOn == false)
        {
            hazards.text = "Hazards: On";
            isHazardsOn = true;
            PlayerPrefs.SetString("hazards", "true");
        }
        else
        {
            hazards.text = "powerups: Off";
            isHazardsOn = false;
            PlayerPrefs.SetString("hazards", "false");
        }
    }

    public void StaminaScene()
    {
        switch (playerOne.GetComponent<CharacterSelectScreenController>().position)
        {
            case 0:
                PlayerPrefs.SetString("playerOne", "Astronaut");
                Debug.Log("Player 1 selected");
                break;

            case 1:
                PlayerPrefs.SetString("playerOne", "RedCircle");
                break;

            case 2:
                PlayerPrefs.SetString("playerOne", "GreenSquare");
                break;

            case 3:
                PlayerPrefs.SetString("playerOne", "NarbyDallin");
                break;
        }
        switch (playerTwo.GetComponent<CharacterSelectScreenController>().position)
        {
            case 0:
                PlayerPrefs.SetString("playerTwo", "Astronaut");
                Debug.Log("Player 2 selected Red circle");
                break;

            case 1:
                PlayerPrefs.SetString("playerTwo", "RedCircle");
                Debug.Log("Player 2 selected Green Square");
                break;

            case 2:
                PlayerPrefs.SetString("playerTwo", "Greensquare");
                break;

            case 3:
                PlayerPrefs.SetString("playerOne", "NarbyDallin");
                break;
        }
        SceneManager.LoadScene("StaminaMode");
    }



}
