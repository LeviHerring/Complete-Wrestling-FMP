using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; 

public class PinningButtonMash : MonoBehaviour
{
    Image metre;
    GameObject text; 
    public float mashDelay = .5f;
    Text winner;
    public GameObject Hitbox; 

    [SerializeField] string winnerText; 

    float mash;
    bool pressed;
    bool started;
    public int pressAmount= 1;
    public int havePressed;
    public float fillAmount;
    public int submissionNo;
    public int minrange = 1;
    public int maxrange = 10000;
    int randomSubmit;
    public bool hasWon;
    public bool isMashingNeeded; 

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<PlayerAttachedMultiplayer>().playerNo == 1)
        {
            //text = ComponentManager.instance.text;
            metre = ComponentManager.instance.player1Metre;
            winner = ComponentManager.instance.player1WinnerText;
        }
        else
        {
            //text = ComponentManager.instance.player2HealthText;
            metre = ComponentManager.instance.player2Metre;
            winner = ComponentManager.instance.player2WinnerText;
        }
        minrange = 1;
        maxrange = 10;
        submissionNo = Random.Range(1, 9); 
    }

    // Update is called once per frame
    void Update()
    {
       if(havePressed == pressAmount)
        {
            Debug.Log("You did it");
            text.gameObject.SetActive(true); 
        }
        metre.fillAmount = fillAmount;

    }

    public void Mashing(InputAction.CallbackContext context)
    {
        if(isMashingNeeded == true)
        {
            if (context.performed)
            {
                havePressed++;
                fillAmount = havePressed / 10;
                metre.fillAmount = fillAmount;


            }
            if(havePressed == pressAmount)
            {
                hasWon = true; 
            }
        }
      
    }


    public void submission(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            randomSubmit = Random.Range(minrange, maxrange);
            if (submissionNo == randomSubmit)
            {
                Debug.Log("SUBMIT");
                winner.gameObject.SetActive(true);
                winner.text = winnerText; 
            }
            else
            {
                Debug.Log("DON'T SUBMIT");
            }
        }
      
    }

    public void SubmissionTest()
    {
            randomSubmit = Random.Range(minrange, maxrange);
            if (submissionNo == randomSubmit)
            {
                Debug.Log("SUBMIT");
                winner.gameObject.SetActive(true);
                winner.text = winnerText;
            }
            else
            {
                Debug.Log("DON'T SUBMIT");
            }

    }


}
