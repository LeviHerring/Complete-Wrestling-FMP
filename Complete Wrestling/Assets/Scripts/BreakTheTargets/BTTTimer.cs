using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class BTTTimer : MonoBehaviour
{
    public float timerUpFloat;
    public float timerDownFloat;
    public Text timerDown;
    public Text timerUp;
    // Start is called before the first frame update
    void Start()
    {
        timerUpFloat = 0f;
        timerDownFloat = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        timerDownFloat -= Time.deltaTime;
        timerUpFloat += Time.deltaTime;
        timerDown.text = "You have " + timerDownFloat + " Seconds Left";
        timerUp.text = "Your time is " + timerUpFloat + " Seconds";

        if(timerDownFloat <= 0)
        {
            SceneManager.LoadScene("Loss"); 
        }
    }
}
