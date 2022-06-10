using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public TargetGlobalVariables targetGlobalVariables; 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hitbox")
        {
            Destroy(gameObject);
            targetGlobalVariables.targetNo--; 
        }
        if(collision.gameObject.tag == "PlayerOne")
        {
            Destroy(gameObject);
            targetGlobalVariables.targetNo--;
        }
    }

}
