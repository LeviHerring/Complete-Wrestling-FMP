using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 

public class TargetGlobalVariables : MonoBehaviour
{
    [SerializeField] public int targetNo;
    public TextMeshProUGUI targetNumber; 

    private void Update()
    {
        targetNumber.text = "There are " + targetNo + " targets left!"; 
        if(targetNo == 0)
        {
            SceneManager.LoadScene("FinishParkourScene"); 
        }
    }
}
