using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 
public class TrainingRoomButtons : MonoBehaviour
{
    public GameObject enemy;
    public Health health;
    GameObject playerOne;
    GameObject playerOneHitbox; 
    public TextMeshProUGUI knockbackX;
    public TextMeshProUGUI knockbackY;
    public TextMeshProUGUI speed;
    public int knockbackMultiplerX;
    public int knockbackMultiplerY;
    public int speedMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        knockbackMultiplerX = 1;
        knockbackMultiplerY = 1;
        speedMultiplier = 1;
        knockbackX.text = "Currently" + knockbackMultiplerX.ToString() + "X knockback"; 
        knockbackY.text = "Currently" + knockbackMultiplerY.ToString() + "X knockback"; 
        speed.text = "Currently" + speedMultiplier.ToString() + "X speed"; 
    }

    // Update is called once per frame
    void Update()
    {
        if(playerOne == null)
        {
            playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("TrainingRoom"); 
    }

    public void AddEnemyPercent()
    {
        health.health += 10; 
    }


    public void MinusEnemyPercent()
    {
        health.health -= 10;
    }

    public void addKnockbackX()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierX += 1;
        //        knockbackMultiplerX++;
        //        knockbackX.text = "Currently" + knockbackMultiplerX.ToString() + "X knockback";
        //        break;
            
        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}

        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierX += 1;
        knockbackMultiplerX++;
        knockbackX.text = "Currently" + knockbackMultiplerX.ToString() + "X knockback";

    }

    public void MinusKnockbackX()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierX -= 1;
        //        knockbackMultiplerX--;
        //        knockbackX.text = "Currently" + knockbackMultiplerX.ToString() + "X knockback";
        //        break;

        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}
        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierX -= 1;
        knockbackMultiplerX--;
        knockbackX.text = "Currently" + knockbackMultiplerX.ToString() + "X knockback"; 


    }

    public void AddKnockbackY()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierY += 1;
        //        knockbackMultiplerY++;
        //        knockbackY.text = "Currently" + knockbackMultiplerY.ToString() + "X knockback";
        //        break;

        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}

        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierY += 1;
        knockbackMultiplerY++;
        knockbackY.text = "Currently" + knockbackMultiplerY.ToString() + "X knockback";
    }

    public void MinusKnockbackY()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierY -= 1;
        //        knockbackMultiplerY--;
        //        knockbackY.text = "Currently" + knockbackMultiplerY.ToString() + "X knockback";
        //        break;

        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}

        playerOne.GetComponentInChildren<DamageManager>().knockbackMultiplierY -= 1;
        knockbackMultiplerY--;
        knockbackY.text = "Currently" + knockbackMultiplerY.ToString() + "X knockback";
    }

    public void AddSpeed()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponent<PlayerMovementFinal>().horizontal += 1;
        //        speedMultiplier++;
        //        speed.text = "Currently" + speedMultiplier.ToString() + "X speed";
        //        break;

        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}
        playerOne.GetComponent<PlayerMovementFinal>().horizontal += 1;
        speedMultiplier++;
        speed.text = "Currently" + speedMultiplier.ToString() + "X speed";

    }

    public void MinusSpeed()
    {
        //string Player1 = PlayerPrefs.GetString("playerOne");

        //switch (Player1)
        //{
        //    case "PlayerOne":
        //        playerOne.GetComponent<PlayerMovementFinal>().horizontal -= 1;
        //        speedMultiplier--;
        //        speed.text = "Currently" + speedMultiplier.ToString() + "X speed";
        //        break;

        //        //case "PlayerThree":
        //        //    playerThreeHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //        //case "PlayerFour":
        //        //     playerFourHitbox.GetComponent<DamageManager>().knockbackMultiplierX += 1; 
        //        //    break;
        //}
        playerOne.GetComponent<PlayerMovementFinal>().horizontal -= 1;
        speedMultiplier--;
        speed.text = "Currently" + speedMultiplier.ToString() + "X speed";

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
