using UnityEngine;
using System.Linq;
using System.Collections; 
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.UI; 

public class PlayerMovementFinal : MonoBehaviour
{
    public Vector2 knockback; 
    public bool isHit;
    public PlayerOneHurtboxes hurtboxes; 
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float hitHorizontal;
    public float hitVertical; 
    //public Text countdownText; 
    public float horizontal;
    private float speed = 10f;
    private float baseSpeed = 10f; 
    private float jumpingPower = 10f;
    public bool isFacingRight = true;
    public float directionFloat; 
    private float dashSpeed = 30f;
    private float dashTime = 0.2f;
    public float startDashTime;
    private int direction;
    private bool isDashing = false;
    bool canDoubleJump;
    AnimationEvents animationEvents;
    Animator animator; 
    Vector3 lastVelocity;
    private PlayerInput playerInput;
    private Mover mover;
    public GameObject[] Tags1;
    public float pinDistance = 10f;
    //[SerializeField] public CountdownTimer countdownTimer; 

    [SerializeField] public GameObject neutral;

    [SerializeField] GameObject special;

    [SerializeField] GameObject strong;
    [SerializeField] GameObject forwardNeutralAerial;
    [SerializeField] GameObject forwardStrongAerial;

    //[SerializeField] GameObject Pin;

    [SerializeField] private int playerIndex = 0;
    
    [SerializeField] public GameObject projectile;
    public bool isShooting;

    [SerializeField] Transform bulletSpawnPos;

    [SerializeField] float timeToDestroy = 1f;

    PinningButtonMash buttonMashing; 

    Projectile projectilex;
    private void Awake()
    {
        //playerInput = GetComponent<PlayerInput>();
        //var movers = FindObjectOfType<Mover>(); 
        //var index = playerInput.playerIndex;
        //mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);  
    }

    public int GetPlayerIndex()
    {
        return playerIndex; 
    }

    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        animationEvents = GetComponent<AnimationEvents>();
        animator = GetComponent<Animator>();
        Tags1 = GameObject.FindGameObjectsWithTag("Enemy");
        projectilex = GetComponent<Projectile>();
        buttonMashing = GetComponent<PinningButtonMash>(); 
    }

    void Update()
    {
        //lastVelocity = rb.velocity; 

        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }

        if(FindObjectOfType<GloablVariablesManager>().playersJoined == 2)
        {
            animationEvents.isAttacking = false;
            FindObjectOfType<GloablVariablesManager>().playersJoined = 0; 
        }

        //if(IsGrounded() == false)
        //{
        //    animator.SetBool("isJumping", true);
        //}
        //else
        //{
        //    animator.SetBool("isJumping", false); 
        //}

    }


    private void FixedUpdate()
    {

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (GetComponent<AnimationEvents>().isAttacking == true && IsGrounded() == false) 
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (isHit == true)
        {
            rb.velocity = (knockback);
        }
        if (IsGrounded())
        {
            animator.SetBool("isJumping", false); 
        }
        
   
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded() && GetComponent<AnimationEvents>().isAttacking == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            canDoubleJump = true;
            animator.SetBool("isJumping", true); 
        }
        else if (context.performed && !IsGrounded() && canDoubleJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            canDoubleJump = false; 
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        if(GetComponent<AnimationEvents>().isAttacking == false)
        {
            horizontal = context.ReadValue<Vector2>().x;
        }
      
    }

    public void AirDash(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Pressed");
        }
        if (!IsGrounded() && context.performed && !isDashing)
        {
            if(isFacingRight)
            {
                Debug.Log("Pressed in air and looking right");
                StartCoroutine(Dash()); 
                //rb.AddForce(transform.forward * dashSpeed);
                //rb.velocity = Vector2.left * dashSpeed; 
                //StartCoroutine(Dash(1f)); 

            }
            else
            {
                Debug.Log("Pressed in air and looking left");
                StartCoroutine(Dash());
                //rb.AddForce(transform.forward * -dashSpeed);
                //rb.velocity = Vector2.right * dashSpeed;
                //StartCoroutine(Dash(-1f));
            }
           
        }
    }

    public void Neutral(InputAction.CallbackContext context)
    {

        if(context.performed && GetComponent<AnimationEvents>().isAttacking == false && IsGrounded())
        {
            GetComponent<AnimationEvents>().isAttacking = true; 
            neutral.gameObject.SetActive(true); 
            animator.SetBool("isNeutral", true);
            animator.SetBool("isForward", true); 
            Debug.Log("Pressed neutral button"); 
        }
        else if (context.performed && GetComponent<AnimationEvents>().isAttacking == false && !IsGrounded())
        {
            GetComponent<AnimationEvents>().isAttacking = true;
            forwardNeutralAerial.gameObject.SetActive(true);
            animator.SetBool("isNeutral", true);
            animator.SetBool("isForward", true);

        }
    }

    public void Special(InputAction.CallbackContext context)
    {
        if (context.performed && GetComponent<AnimationEvents>().isAttacking == false)
        {
            special.gameObject.SetActive(true);
            animator.SetBool("isSpecial", true);
            animator.SetBool("isForward", true);
            Debug.Log("Pressed Special button");
        }
    }

    public void Strong(InputAction.CallbackContext context)
    {
        if (context.performed && GetComponent<AnimationEvents>().isAttacking == false && IsGrounded())
        {
            strong.gameObject.SetActive(true); 
            animator.SetBool("isStrong", true);
            animator.SetBool("isForward", true);
            Debug.Log("Pressed Strong button");
        }
        else if (context.performed && GetComponent<AnimationEvents>().isAttacking == false && !IsGrounded())
        {
            GetComponent<AnimationEvents>().isAttacking = true;
            forwardStrongAerial.gameObject.SetActive(true);
            animator.SetBool("isNeutral", true);
            animator.SetBool("isForward", true);

        }
    }

    public void UpNeutral(InputAction.CallbackContext context)
    {

    }


    IEnumerator Dash()
    {
        isDashing = true; 
        speed = dashSpeed;

        yield return new WaitForSeconds(dashTime);

        speed = baseSpeed;
        isDashing = false; 
    }

    //public void Pinning(InputAction.CallbackContext context)
    //{
    //    if (context.performed && GetComponent<AnimationEvents>().isAttacking == false && IsGrounded())
    //    {
    //        Debug.Log("Pressed Pin Button button");
    //        foreach(GameObject go in Tags1)
    //        {
    //            if (Vector3.Distance(transform.position, go.transform.position) < pinDistance)
    //            {
    //                Debug.Log("Pin Worked");
    //                countdownText.gameObject.SetActive(true); 
    //                StartCoroutine(countdownTimer.CountdownToStart(3)); 

    //            }
    //        }
    //    }
    //}

    //public void Submission(InputAction.CallbackContext context)
    //{
    //    if (context.performed && GetComponent<AnimationEvents>().isAttacking == false && IsGrounded())
    //    {
    //        GetComponent<AnimationEvents>().isAttacking = true; 
    //        Debug.Log("Pressed Submission Button button");
    //        foreach (GameObject go in Tags1)
    //        {
    //            if (Vector3.Distance(transform.position, go.transform.position) < pinDistance)
    //            {
    //                GetComponent<PinningButtonMash>().SubmissionTest(); 

    //            }
    //        }
    //    }
    //}

    public void Projectile(InputAction.CallbackContext context)
    {
        if (context.performed && !isShooting)
        {
            isShooting = true;

            GameObject b = Instantiate(projectile);
            b.GetComponent<Projectile>().StartShoot(isFacingRight);
            b.transform.position = bulletSpawnPos.transform.position;
            Invoke("ResetShoot", 1f);


        }
    }

    public void UpA(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Up A performed");

        }
    }

    void ResetShoot()
    {
        isShooting = false;
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "RopesRight")
    //    {
    //        Debug.Log("Hit Right");
    //        rb.velocity = new Vector2(-10f, 0f);
    //    }
    //    if (collision.gameObject.tag == "RopesLeft")
    //    {
    //        rb.velocity = new Vector2(10f, 0f);
    //        Debug.Log("Hit Left");
    //    }
    //    if (collision.gameObject.tag == "RopesUp")
    //    {
    //        rb.velocity = new Vector2(0f, -10f);
    //    }


    //}
}