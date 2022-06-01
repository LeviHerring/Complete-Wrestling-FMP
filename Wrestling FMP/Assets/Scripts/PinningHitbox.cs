using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinningHitbox : MonoBehaviour
{
    public GameObject player;
    GameObject opponentOne;
    string opponentTag; 
    // Start is called before the first frame update
    void Start()
    {
        if (player.GetComponent<PlayerAttachedMultiplayer>().playerNo == 1)
        {
            opponentOne = GameObject.FindGameObjectWithTag("PlayerTwo");
            opponentTag = "PlayerTwo"; 
            Debug.Log(player.activeSelf);
        }
        else
        {
            opponentTag = "PlayerOne"; 
            opponentOne = GameObject.FindGameObjectWithTag("PlayerOne");
            Debug.Log(player.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (opponentOne == null)
        {
            opponentOne = GameObject.FindGameObjectWithTag(opponentTag);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == opponentTag)
        {
            player.GetComponent<AnimationEvents>().isAttacking = true;
            //player.GetComponent<Animator>().SetBool("IsPinning", true);
            player.GetComponent<NewPinningAndSubmittingAndMashing>().HasOpponentWon();

        }
    }
}
