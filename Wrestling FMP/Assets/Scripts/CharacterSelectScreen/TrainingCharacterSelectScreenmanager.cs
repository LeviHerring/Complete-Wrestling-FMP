using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TrainingCharacterSelectScreenmanager : MonoBehaviour
{
    public GameObject playerOne;
    //public GameObject playerTwo; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne.GetComponent<CharacterSelectScreenController>().isSelected == true)
        {
            switch (playerOne.GetComponent<CharacterSelectScreenController>().position)
            {
                case 0:
                    PlayerPrefs.SetString("playerOne", "RedCircle");
                    Debug.Log("Player 1 selected");
                    break;

                case 1:
                    PlayerPrefs.SetString("playerOne", "GreenSquare");
                    break;

                    //case 2:
                    //    PlayerPrefs.SetString("playerOne", "PlayerThree");
                    //    break;

                    //case 3:
                    //    PlayerPrefs.SetString("playerOne", "PlayerFour");
                    //    break; 
            }
            SceneManager.LoadScene("TrainingRoom");
        }
    }
}