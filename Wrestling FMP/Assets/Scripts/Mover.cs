using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetPlayerIndex()
    {
        return playerIndex; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
