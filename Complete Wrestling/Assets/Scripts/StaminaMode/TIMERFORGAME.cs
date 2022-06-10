using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class TIMERFORGAME : MonoBehaviour
{
    public float stopwatch;
    public Text timer; 
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = 480f;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = stopwatch + " Time left"; 
        stopwatch -= Time.deltaTime; 

        if(stopwatch <= 0)
        {
            SceneManager.LoadScene("NoOneWins");
        }
    }
}
