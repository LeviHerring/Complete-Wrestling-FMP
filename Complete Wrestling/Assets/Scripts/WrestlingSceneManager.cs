using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WrestlingSceneManager : MonoBehaviour
{
    public GameObject barriers; 
    public GloablVariablesManager globalVariables; 
    public int countdownTime;
    public Text countdownDisplay;
    //public PinningButtonMash pinningButtonMash;
     [SerializeField] GameObject playerOne;
     [SerializeField] GameObject playerTwo;
    //public GameObject playerThree;
    //public GameObject playerFour;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CountdownToStart(5));
        //pinningButtonMash.isMashingNeeded = true; 
        barriers.SetActive(true); 
        playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
        //playerOne.GetComponent<AnimationEvents>().isAttacking = true;
        //playerTwo.GetComponent<AnimationEvents>().isAttacking = true;

        //playerThree.GetComponent<AnimationEvents>().isAttacking = true;
        //playerFour.GetComponent<AnimationEvents>().isAttacking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerOne == null || playerTwo == null)
        {
            playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
            playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
            
        }

        //if(playerOne.GetComponent<NewPinningAndSubmittingAndMashing>().hasWon == true)
        //{
        //    Debug.Log("WINNER!");
        //    StartCoroutine(Winner());

        //}
        //if(playerTwo.GetComponent<PinningButtonMash>().hasWon == true)
        //{
        //    Debug.Log("Winner!");
        //}

        if (globalVariables.realPlayerNumber == 2)
        {
            barriers.SetActive(true);
            playerOne.GetComponent<AnimationEvents>().isAttacking = true;
            playerTwo.GetComponent<AnimationEvents>().isAttacking = true;
            StartCoroutine(CountdownToStart(5));
        }
    }

    public IEnumerator CountdownToStart(int countdownTime2)
    {
        globalVariables.realPlayerNumber = 3;
        while (countdownTime2 > 0)
        {
            countdownDisplay.gameObject.SetActive(true); 
            countdownDisplay.text = countdownTime2.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime2--;



        }

        countdownDisplay.text = "FIGHT!";
        //bell sound rings here
        playerOne.GetComponent<AnimationEvents>().isAttacking = false;
        playerTwo.GetComponent<AnimationEvents>().isAttacking = false;
        barriers.SetActive(false);
        //playerThree.GetComponent<AnimationEvents>().isAttacking = false;
        //playerFour.GetComponent<AnimationEvents>().isAttacking = false;

        yield return new WaitForSeconds(1f);
        globalVariables.realPlayerNumber = 3; 
        countdownDisplay.gameObject.SetActive(false);
        barriers.SetActive(false);
        playerOne.GetComponent<AnimationEvents>().isAttacking = false;
        playerTwo.GetComponent<AnimationEvents>().isAttacking = false;
    }

    //IEnumerator Winner()
    //{
    //     yield return new WaitForSeconds(5f);
    //    playerOne.GetComponent<PinningButtonMash>().hasWon = false;
    //}
}
