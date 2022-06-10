using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarbyDallinHitbox : MonoBehaviour
{

    public DamageManager dm;
    public bool isActivated;
    public float stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Hitbox")
        {
            isActivated = true;
            stopwatch = 5; 
        }
    }
}
