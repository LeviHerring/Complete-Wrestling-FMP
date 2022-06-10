using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class GrabController : MonoBehaviour
{

    public Transform grabDetect;
    public Transform holder;
    public float rayDist; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void PickUp(InputAction.CallbackContext context)
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if (grabCheck.collider != null && grabCheck.collider.tag == "Grabbable")
        {
            if (context.performed)
            {
                grabCheck.collider.gameObject.transform.parent = holder;
                grabCheck.collider.gameObject.transform.position = holder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true; 



            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false; 
            }
        }
    }
}
