using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ParkourTimer : MonoBehaviour
{

    public Text text;
    public GameObject giveUpText; 
    public float stopwatch; 
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "You've got " + " Seconds left"; 

        stopwatch -= Time.deltaTime;

        if(stopwatch <= 0)
        {
            SceneManager.LoadScene("Loss"); 
        }
        if(stopwatch <= 280f)
        {
            giveUpText.SetActive(false); 
        }
    }
}
