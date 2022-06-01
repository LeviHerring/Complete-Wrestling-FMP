using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ComponentManager : MonoBehaviour
{
    public static ComponentManager instance;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public Text player1HealthText; 
    public Text player2HealthText; 
    public Text player1Countdown; 
    public Text player2Countdown;
    public Image player1Metre;
    public Image player2Metre;
    public CountdownTimer player1countdownTimer;
    public CountdownTimer player2countdownTimer;
    public Image player1MashingMetre;
    public Image player2MashingMetre;
    public Text player1WinnerText;
    public Text player2WinnerText;
    public Text player1Stamina;
    public Text player2Stamina;
    public Text player1MashingNeededText;
    public Text player2MashingNeededText;
    public TextMeshProUGUI playerJoin; 
}
