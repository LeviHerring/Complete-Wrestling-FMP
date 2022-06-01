using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloablVariablesManager : MonoBehaviour
{
    public Transform playerOneSpawn;
    public Transform playerTwoSpawn;
    public int player1MashingDone;
    public int player2MashingDone;
    public int player3MashingDone;
    public int player4MashingDone;

    public float minrange = 1;
    public float maxrange = 10000;
    public float minrangePlayer2 = 1;
    public float maxrangePlayer2 = 10000;
    public float minrangePlayer3 = 1;
    public float maxrangePlayer3 = 10000;
    public float minrangePlayer4 = 1;
    public float maxrangePlayer4 = 10000;
    public float playersJoined = 0;
    public int playerNo;
    public int realPlayerNumber; 

    // Start is called before the first frame update
    void Start()
    {
         playersJoined = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
