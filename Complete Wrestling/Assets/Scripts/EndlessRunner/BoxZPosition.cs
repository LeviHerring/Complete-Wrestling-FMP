using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxZPosition : MonoBehaviour
{
    GameObject box;
    Transform transformBox; 
    // Start is called before the first frame update
    void Start()
    {
        box = GameObject.FindGameObjectWithTag("Box");
        transformBox = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (box == null)
        {
            box = GameObject.FindGameObjectWithTag("Box");
        }

    }
}
