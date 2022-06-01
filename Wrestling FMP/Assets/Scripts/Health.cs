using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; 

public class Health : MonoBehaviour
{
    Text healthText;
    Text staminaText; 
    Image superMetre;
    public float superMetreCharge = 0f; 

    [SerializeField] string playerNo;

    [SerializeField] public float stamina; 

    public float health = 0f;

    string playerWins; 

    
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<PlayerAttachedMultiplayer>().playerNo == 1)
        {
            healthText = ComponentManager.instance.player1HealthText;
            superMetre = ComponentManager.instance.player1Metre;
            staminaText = ComponentManager.instance.player1Stamina;
            playerWins = "PlayerTwoWins";
        }
        else
        {
            healthText = ComponentManager.instance.player2HealthText;
            superMetre = ComponentManager.instance.player2Metre;
            staminaText = ComponentManager.instance.player2Stamina;
            playerWins = "PlayerOneWins";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        staminaText.text = stamina + "/100"; 
        healthText.text = health + "%";  
        if (superMetreCharge > 1)
        {
            superMetreCharge = 1f; 
        }
        superMetre.fillAmount = superMetreCharge;

        if(stamina <= 0)
        {
            Debug.Log("Lose!");
            SceneManager.LoadScene(playerWins); 
        }
    }

    public void Damage(float damagePoints, float superMetreChargePoints, float staminaPoints)
    {
        health += damagePoints;
        superMetreCharge += superMetreChargePoints;
        stamina -= staminaPoints; 
    }

    public void Finisher(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            if(superMetreCharge == 1)
            {
                Debug.Log("SuperAttack");
            }
            else
            {
                Debug.Log("Do not do Super Attack"); 
            }
        }
    }
}
