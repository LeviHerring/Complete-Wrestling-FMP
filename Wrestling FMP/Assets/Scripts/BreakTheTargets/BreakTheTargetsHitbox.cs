using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTheTargetsHitbox : MonoBehaviour
{
    GameObject player;
    public Transform respawnPoint; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerOne");
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
          player = GameObject.FindGameObjectWithTag("PlayerOne");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerOne") ;
        {
            player.transform.position = respawnPoint.transform.position; 
        }
    }


}
