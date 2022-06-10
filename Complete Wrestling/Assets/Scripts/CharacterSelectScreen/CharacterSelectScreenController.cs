using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CharacterSelectScreenController : MonoBehaviour
{
    [SerializeField] public int playerNo;

    public SpriteRenderer spriteRenderer; 

    [SerializeField] public int position = 2;

    [SerializeField] public int[] bounds;

    [SerializeField] public string player; 

    public bool isSelected; 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.enabled = true;
        isSelected = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Left(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            if(!(position <= bounds[0]))
            {
                position = position - 1;
                transform.position += new Vector3(-3.5f, 0, 0);
            }
                
        }
    }
    public void Right(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Pressed right"); 
            if(!(position >= bounds[1]))
            {
                position = position + 1;
                transform.position += new Vector3(3.5f, 0, 0);
            }
          
        }
    }

    public void Select(InputAction.CallbackContext context)
    {
        Debug.Log("Pressed"); 
        if (context.performed)
        {
            isSelected = true;
            spriteRenderer.enabled = false; 
        }
      
    }

    public void Back(InputAction.CallbackContext context)
    {
        Debug.Log("Pressed");
        if (context.performed)
        {
            isSelected = false;
            spriteRenderer.enabled = true;
        }

    }

    public void Trigger(InputAction.CallbackContext context)
    {
        Debug.Log(player + "Pressed Trigger"); 
    }
}
