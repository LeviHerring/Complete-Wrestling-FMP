using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public PinningButtonMash pinningButtonMash; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart(3));
        //pinningButtonMash.isMashingNeeded = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator CountdownToStart(int countdownTime2)
    {
        while(countdownTime2 > 0)
        {
            //if (/*pinningButtonMash.hasWon == true &&*/ countdownTime2 > 0)
            //{
            //    countdownDisplay.text = "Pin broken!";
            //}
            //else
            //{
                countdownDisplay.text = countdownTime2.ToString();

                yield return new WaitForSeconds(1f);

                countdownTime2--;
            //}
           
            
           
        }

        countdownDisplay.text = "Pinned!";

        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }

    //Need to find somewhere, where if the amount to mash is reached, the countdown is reset and is disabled from the scene until needed again. 
    //Can't do it in the white as it will always be about 0 alot of the time and that crashes the game
    //

}
