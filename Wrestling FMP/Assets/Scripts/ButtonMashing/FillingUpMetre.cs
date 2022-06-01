using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem; 
public class FillingUpMetre : MonoBehaviour
{
    public Image metre;
    public float fillAmount;
    public int mashingNeeded = 1;
    public int amountMashed = 1;
    public bool hasWon;
    public TextMeshProUGUI amountMashedOutOfAmountNedded;
    public TextMeshProUGUI lives;
    public TextMeshProUGUI countdown;
    public TextMeshProUGUI start; 
    public int livesAmount;
    public bool canMash = true;
    public float stopwatch;
    public bool canLose; 
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = 3f; 
        mashingNeeded = 20;
        StartCoroutine(StartCoroutine()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(canMash)
        {
            stopwatch -= Time.deltaTime;
        }
        amountMashedOutOfAmountNedded.text = amountMashed + "/" + mashingNeeded;
        countdown.text = stopwatch.ToString("F1");
        lives.text = "lives: " + livesAmount;
        metre.fillAmount = fillAmount;
        if(stopwatch <= 0 && hasWon == false && canMash == true & canLose == true)
        {
            livesAmount--;
            stopwatch = 3; 
        }
        if(livesAmount <= 0 && canLose == true)
        {
            SceneManager.LoadScene("Loss"); 
        }
    }

    public void Mashing(InputAction.CallbackContext context)
    {
        if(context.performed && canMash)
        {
            amountMashed++;
            fillAmount = amountMashed / 10;
            metre.fillAmount = fillAmount;
        }
        if (amountMashed == mashingNeeded)
        {
            canLose = false; 
            canMash = false; 
            hasWon = true;
            canMash = false;
            StartCoroutine(HasWon());
        }
    }


    IEnumerator HasWon()
    {
        amountMashed = 0;
        metre.fillAmount = 0;
        mashingNeeded += 10;
        yield return new WaitForSeconds(3f); 
        stopwatch = 3;
        canMash = true;
        canLose = true;
        hasWon = false; 
    }

    IEnumerator StartCoroutine()
    {
        start.text = "Ready";
        yield return new WaitForSeconds(3f);
        canMash = true;
        start.text = "Go!";
        stopwatch = 3f;
        canLose = true; 
    }
}
