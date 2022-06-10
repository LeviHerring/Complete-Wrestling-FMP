using UnityEngine;

public class Hitbox : MonoBehaviour
{

    [SerializeField] public float damageAmount;
    [SerializeField] public float staminaPoints;
    [SerializeField] public float damageAmountDivide;
    public DamageManager damageManager; 
    [SerializeField] public float superMetreChargeAmount;
    [SerializeField] public Vector2 knockback;
    [SerializeField] public float verticalKnockbackForce;
    [SerializeField] public float hitstun;
    public GameObject playerWithHitboxes;
    PlayerMovementFinal playerMovementFinal;
    [SerializeField] public float hitHorizontal; 
    [SerializeField] public float hitVertical; 

    [SerializeField] GameObject player;
    //public GameObject player2;
    //public GameObject player3;
    //public GameObject player4;

    string playerString; 


    Health health; 
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        damageAmount = damageManager.damage * damageManager.damageMultiplier;
        playerMovementFinal = GetComponent<PlayerMovementFinal>(); 
        if(playerWithHitboxes.GetComponent<PlayerAttachedMultiplayer>().playerNo == 1)
        {
            player = GameObject.FindGameObjectWithTag("PlayerTwo");
            playerString = "PlayerTwo"; 
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("PlayerOne");
            playerString = "PlayerOne"; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag(playerString);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        //Debug.Log("HIT DETECTED");

        if (collision.gameObject.name == playerString)
        {
           

            Debug.Log("DETECTION");
            player.GetComponent<Health>().Damage(damageAmount, superMetreChargeAmount, staminaPoints);
            if (playerWithHitboxes.GetComponent<PlayerMovementFinal>().isFacingRight == true)
            {
                Vector2 newKnockback = new Vector2(knockback.x * damageManager.knockbackMultiplierX, knockback.y * damageManager.knockbackMultiplierY);
                player.GetComponent<PlayerKnockback>().DoKnockBack(/*hitstun,*/ newKnockback /*hitHorizontal, hitVertical*/);

            }
            else
            {
                Vector2 newKnockback = new Vector2(-knockback.x * damageManager.knockbackMultiplierX, knockback.y * damageManager.knockbackMultiplierY);
                player.GetComponent<PlayerKnockback>().DoKnockBack(newKnockback /*hitHorizontal * -1, hitVertical*/);
            }
        }
        




        //player.GetComponentInChildren<PlayerHurtboxes>().disabledTime = hitstun; 

        //Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
        //if (enemy != null)
        //{
        //    enemy.isKinematic = false;
        //    Vector2 difference = enemy.transform.position - transform.position;
        //    difference = difference.normalized * knockback;
        //    enemy.AddForce(difference, ForceMode2D.Impulse);
        //    enemy.isKinematic = true;
        //}
    }
        //if (collision.gameObject.name == player2.gameObject.name)
        //{


        //    Debug.Log("DETECTION");
        //    player2.GetComponent<Health>().Damage(damageAmount, superMetreChargeAmount);

        //    Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
        //    if (enemy != null)
        //    {
        //        enemy.isKinematic = false;
        //        Vector2 difference = enemy.transform.position - transform.position;
        //        difference = difference.normalized * knockback;
        //        enemy.AddForce(difference, ForceMode2D.Impulse);
        //        enemy.isKinematic = true;
        //    }
        //}
        //if (collision.gameObject.name == player3.gameObject.name)
        //{


        //    Debug.Log("DETECTION");
        //    player3.GetComponent<Health>().Damage(damageAmount, superMetreChargeAmount);

        //    Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
        //    if (enemy != null)
        //    {
        //        enemy.isKinematic = false;
        //        Vector2 difference = enemy.transform.position - transform.position;
        //        difference = difference.normalized * knockback;
        //        enemy.AddForce(difference, ForceMode2D.Impulse);
        //        enemy.isKinematic = true;
        //    }
        //}
        //if (collision.gameObject.name == player4.gameObject.name)
        //{


        //    Debug.Log("DETECTION");
        //    player4.GetComponent<Health>().Damage(damageAmount, superMetreChargeAmount);

        //    Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
        //    if (enemy != null)
        //    {
        //        enemy.isKinematic = false;
        //        Vector2 difference = enemy.transform.position - transform.position;
        //        difference = difference.normalized * knockback;
        //        enemy.AddForce(difference, ForceMode2D.Impulse);
        //        enemy.isKinematic = true;
        //    }
        //}

        //if(collision.tag == "PictureInPicture")
        //{
        //    Debug.Log("And we'll be back after these messages");

        //}
    //}



}

