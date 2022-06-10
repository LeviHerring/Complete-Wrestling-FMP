using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro; 

public class ButtonSelectResetScene : MonoBehaviour
{
    public Button primaryButton;

    // Start is called before the first frame update
    void Start()
    {
        primaryButton.Select(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
