using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class WeaponSwitching : MonoBehaviour
{

    public int selectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true); 
            else
                weapon.gameObject.SetActive(false);
            i++; 
        }
    }

    public void ChangeWeapon(InputAction.CallbackContext context)
    {
        int previousSelected = selectedWeapon; 

        if(context.performed)
        {
            //Debug.Log("Pressed b button"); 
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0; 
            else
            selectedWeapon++; 


        }
        if (context.performed && selectedWeapon == 3)
        {
            selectedWeapon = 0; 
        }

        if(previousSelected != selectedWeapon)
        {
            SelectWeapon(); 

        }
    }
}
