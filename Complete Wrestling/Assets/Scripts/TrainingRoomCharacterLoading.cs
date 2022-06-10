using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingRoomCharacterLoading : MonoBehaviour
{
    public GameObject redCircle;
    public GameObject greenSquare;
    public GameObject astronaut;
    public GameObject narbyDallin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        string player1 = PlayerPrefs.GetString("playerOne");
        switch (player1)
        {
            case "RedCircle":
                Debug.Log("Spawned player 2 as red circle");
                redCircle.SetActive(true); 
                break;
            case "GreenSquare":
                Debug.Log("Spawned player 2 as green square");
                greenSquare.SetActive(true);
                break;
            case "Astronaut":
                astronaut.SetActive(true); 
                break;
            case "NarbyDallin":
                narbyDallin.SetActive(true); 
                break;
        }

    }
}
