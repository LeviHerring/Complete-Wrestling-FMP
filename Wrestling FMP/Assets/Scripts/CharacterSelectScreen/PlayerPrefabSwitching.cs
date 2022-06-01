using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerPrefabSwitching : MonoBehaviour
{
    public GameObject playerTwo; 
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerInputManager>().playerPrefab = playerTwo; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
