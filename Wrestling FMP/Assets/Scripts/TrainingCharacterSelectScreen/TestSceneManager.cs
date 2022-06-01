using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class TestSceneManager : MonoBehaviour
{
    public EventSystem eventSystem;
    public GameObject eventSystemObject; 
    public GameObject playerOne;
    public GameObject panel;
    public GameObject GameModePanel;
    public GameObject button;
    public GameObject buttonTwo;
    public GameObject startButton;
    public GameObject backButton; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        //playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        //playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne.GetComponent<CharacterSelectScreenController>().isSelected == true)
        {
            panel.SetActive(true);
            eventSystem.firstSelectedGameObject = button;
            
        }
    }

    public void StartButton()
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
        GameModePanel.SetActive(true);
        panel.SetActive(false);
        startButton.SetActive(false);
        backButton.SetActive(false); 
        eventSystem.firstSelectedGameObject = buttonTwo;
    }

    public void BackButton()
    {
        playerOne.GetComponent<CharacterSelectScreenController>().isSelected = false;
        playerOne.GetComponent<SpriteRenderer>().enabled = true; 
        panel.gameObject.SetActive(false);
    }

    public void BackButtonTwo()
    {
        GameModePanel.SetActive(false);
        eventSystem.firstSelectedGameObject = buttonTwo;
    }

    public void TrainingRoom()
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
        SceneManager.LoadScene("TrainingRoom"); 
    }

    public void EndlessRunner()
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
        SceneManager.LoadScene("EndlessRunner");
    }

    public void RandomPlatformer()
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
        SceneManager.LoadScene("ParkourTraining"); 
    }

    public void BreakTheTargets()
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
        SceneManager.LoadScene("BreakTheTargets");
    }
}
