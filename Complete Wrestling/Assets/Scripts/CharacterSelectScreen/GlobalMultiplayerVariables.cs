using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMultiplayerVariables : MonoBehaviour
{
    public int playerIndex;
    // Start is called before the first frame update

    private void Awake()
    {
        playerIndex = 1; 
    }
    void Start()
    {
        playerIndex = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
