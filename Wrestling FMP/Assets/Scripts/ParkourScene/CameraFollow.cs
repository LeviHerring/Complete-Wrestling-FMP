using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player; 
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerOne");
        target = player.transform; 
    }

    private void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("PlayerOne");
        }
        if(target == null)
        {
            target = player.transform; 
        }
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = transform.position = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target); 
    }
}
