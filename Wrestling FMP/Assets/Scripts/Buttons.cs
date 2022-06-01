using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Buttons : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject panel;
    public EventSystem eventSystem;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CSS()
    {
        SceneManager.LoadScene("CharacterSelectScreen");
    }

    public void SinglePlayer()
    {
        panel.SetActive(true);
        firstPanel.SetActive(false);
        eventSystem.firstSelectedGameObject = button;

    }

    public void EndlessRunner()
    {
        SceneManager.LoadScene("EndlessRunner");
    }

    public void TrainingRoom()
    {
        SceneManager.LoadScene("TrainingCharacterSelectScreen");
    }

    public void ParkourTrainingRoom()
    {
        SceneManager.LoadScene("ParkourTraining");
    }

    public void ButtonMashing()
    {
        SceneManager.LoadScene("ButtonMashingPractice"); 
    }

    public void RNG()
    {
        SceneManager.LoadScene("RNGTester");
    }

    public void BreakTheTarget()
    {
        SceneManager.LoadScene("BreakTheTargets");
    }

    public void MultiplayerModes()
    {
        SceneManager.LoadScene("MultiplayerModes"); 
    }

    public void SingleplayerModes()
    {
        SceneManager.LoadScene("SingleplayerModes"); 
    }

    public void StaminaMode()
    {
        SceneManager.LoadScene("StaminaCSS");
    }

}