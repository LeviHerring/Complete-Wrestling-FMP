using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{

    [SerializeField] public float damage;
    [SerializeField] public float damageMultiplier;
    [SerializeField] public float knockbackMultiplierX;
    [SerializeField] public float knockbackMultiplierY;
    // Start is called before the first frame update
    void Start()
    {
        knockbackMultiplierX = 1;
        knockbackMultiplierY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
