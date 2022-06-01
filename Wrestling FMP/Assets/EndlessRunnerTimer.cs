using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndlessRunnerTimer : MonoBehaviour
{
    public Text timerText;
    public Text pointsText;
    public int points; 
    public float stopwatch; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points + "points"; 
        stopwatch += Time.deltaTime;
        timerText.text = stopwatch + " Seconds"; 

        if(stopwatch % 5 == 0)
        {
            points++; 
        }
    }
}
