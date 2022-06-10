using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerSetup : MonoBehaviour
{
    public Transform parent; 
    public GameObject playerOne;
    public GameObject playerTwo;
    //public GameObject playerThree;
    //public GameObject playerFour;

    public GameObject spawnPosition; 

    // Start is called before the first frame update
    void Start()
    {
        string Player2 = PlayerPrefs.GetString("playerTwo");

        switch (Player2)
        {
            case "PlayerOne":
                Instantiate(playerOne, spawnPosition.transform.position, Quaternion.identity, gameObject.transform); 
                break;
            case "PlayerTwo":
                Instantiate(playerTwo, spawnPosition.transform.position, Quaternion.identity, gameObject.transform);
                break;
            //case "PlayerThree":
            //    Instantiate(playerThree, spawnPosition.transform.position, Quaternion.identity);
            //    break;
            //case "PlayerFour":
            //    Instantiate(playerFour, spawnPosition.transform.position, Quaternion.identity);
            //    break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
