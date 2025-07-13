using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject CompCan;
    public GameObject ChairObj;
    public GameObject ComputerBoot;
    public GameObject ComputerScreen;
    public bool inComp;
    Chair chair;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public GameObject Bed;
    sleep Sleep;
    public GameObject Window;
    public string animationName;
    public float speed = 12f;
    public float horizontal;
    public float jumpPower = 16f;
    private bool isFacingRight = true;
    public float ClockTime; 
    public float HourCount;
    public float DayCount;
    public float YearCount;
    animation Anim;
    public float Monies;
    public float WorkSpeed;
    public bool CloseToWork;

    Minigames Minigames;
    

    public float BootUp;

    void Start()
    {
        Minigames = ComputerScreen.GetComponent<Minigames>();
        ComputerScreen.SetActive(false);
        BootUp = 0f;
        chair = ChairObj.GetComponent<Chair>(); ;
        CompCan.SetActive(false);
        Anim = Window.GetComponent<animation>();    
        Monies = 0;
        Sleep = Bed.GetComponent<sleep>();
        ClockTime = 0f;
        DayCount = 1;
        HourCount = 8;
        YearCount = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (inComp)
        {
            BootUp += Time.deltaTime;
            if (BootUp >= 2f)
            {
                ComputerBoot.SetActive(false);
                ComputerScreen.SetActive(true);
            }
        }
        BedFunc();
        ClockFunc();

        if (chair.inRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Activated");
            CompCan.SetActive(true);
            ComputerBoot.SetActive(true);
            BootUp = 0f;
            inComp = true;
        }
        if (inComp == true && Input.GetKeyDown(KeyCode.Escape) && Minigames.InMarket == false && Minigames.inEmail == false)
        {
            Debug.Log("Deactivated");
            inComp = false;

            ComputerScreen.SetActive(false);
            CompCan.SetActive(false);

        }

        ClockTime += Time.deltaTime;
        horizontal = Input.GetAxisRaw("Horizontal");


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
        if (Input.GetButtonUp("Jump") && rb.linearVelocity.x > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
        Flip();

    }

    private void BedFunc()
    {
        if (Input.GetKeyDown(KeyCode.E) && Sleep.inRange && HourCount >= 20)
        {
            Anim.AnimRestart();
            HourCount = 8;
            DayCount++;
        }
    }

    private void ClockFunc()
    {
        if (ClockTime >= 20)
        {
            HourCount++;
            ClockTime = 0;
        }
        if (HourCount == 24)
        {
            HourCount = 0;
            DayCount ++;
            
        }
        if (DayCount >= 365)
        {
            DayCount = 0;
            YearCount++;
        }
    }

    private void FixedUpdate() {
        if (!inComp)
        {
            rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
        }
    }
    
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
    private void Flip()
    {
        if (!inComp)
        {
            if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
            {
                isFacingRight = false;
                Vector2 localScale = transform.localScale;
                transform.localScale = localScale;

            }
        }
    }
}
