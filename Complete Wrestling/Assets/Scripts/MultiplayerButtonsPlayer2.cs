using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerButtonsPlayer2 : MonoBehaviour
{
    public void PlayerOne()
    {
        PlayerPrefs.SetString("playerTwo", "PlayerOne");
    }
    public void PlayerTwo()
    {
        PlayerPrefs.SetString("playerTwo", "PlayerTwo");
    }
    public void PlayerThree()
    {
        PlayerPrefs.SetString("playerTwo", "PlayerThree");
    }
    public void PlayerFour()
    {
        PlayerPrefs.SetString("playerTwo", "PlayerFour");
    }
}
