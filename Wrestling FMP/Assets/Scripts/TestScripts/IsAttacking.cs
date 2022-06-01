using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAttacking : MonoBehaviour
{
    public AnimationEvents animationEvents; 
    // Start is called before the first frame update
    void Start()
    {
        animationEvents.isAttacking = false; 
    }

    // Update is called once per frame
    void Update()
    {
        animationEvents.isAttacking = false;
    }
}
