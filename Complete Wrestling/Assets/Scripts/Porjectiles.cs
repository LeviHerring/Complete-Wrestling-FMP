using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Porjectiles : MonoBehaviour
{
    [SerializeField] public GameObject projectile;
    public bool isShooting;

    [SerializeField] Transform bulletSpawnPos;

    [SerializeField] float timeToDestroy = 1f; 

    PlayerMovementFinal playerMovementFinal; 

    Projectile projectilex;
    // Start is called before the first frame update
    void Start()
    {
        projectilex = GetComponent<Projectile>(); 
        playerMovementFinal = GetComponent<PlayerMovementFinal>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Projectile(InputAction.CallbackContext context)
    {
        if(context.performed && !isShooting)
        {
                isShooting = true;

                GameObject b = Instantiate(projectile);
                GetComponent<Projectile>().StartShoot(GetComponent<PlayerMovementFinal>().isFacingRight); 
                b.transform.position = bulletSpawnPos.transform.position;
                Invoke("ResetShoot", 1f);


        }
    }

    void ResetShoot()
    {
        isShooting = false; 
    }
}
