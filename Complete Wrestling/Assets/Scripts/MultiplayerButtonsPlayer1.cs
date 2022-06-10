using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerButtonsPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerOne()
    {
        PlayerPrefs.SetString("playerOne", "PlayerOne");
    }
    public void PlayerTwo()
    {
        PlayerPrefs.SetString("playerOne", "PlayerTwo");
    }
    public void PlayerThree()
    {
        PlayerPrefs.SetString("playerOne", "PlayerThree");
    }
    public void PlayerFour()
    {
        PlayerPrefs.SetString("playerOne", "PlayerFour");
    }

}
