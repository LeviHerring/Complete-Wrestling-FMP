using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Player2Join : MonoBehaviour
{
    TextMeshProUGUI joinText; 
    // Start is called before the first frame update
    void Start()
    {
        joinText = FindObjectOfType<TextMeshProUGUI>();
        joinText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
