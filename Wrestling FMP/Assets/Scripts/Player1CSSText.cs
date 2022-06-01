using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Player1CSSText : MonoBehaviour
{
     TextMeshProUGUI joinText;
    // Start is called before the first frame update
    void Start()
    {
        joinText = FindObjectOfType<TextMeshProUGUI>();
        joinText.text = "Player 2 Press any button to join";
        joinText.enabled = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
