using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public GameObject Bed;
    sleep Sleep;
    public float speed = 12f;
    public float horizontal;
    public float jumpPower = 16f;
    private bool isFacingRight = true;
    public float ClockTime;
    public float HourCount;
    public float DayCount;
    public float YearCount;

    public float Monies;
    public float WorkSpeed;
    public bool CloseToWork;

    void Start()
    {
        Monies = 0;
        Sleep = Bed.GetComponent<sleep>();
        ClockTime = 0f;
        DayCount = 0;
        HourCount = 0;
        YearCount = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("WorkStation"))
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        BedFunc();
        ClockFunc();
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
        if (Input.GetKeyDown(KeyCode.E) && Sleep.inRange)
        {
            if ((HourCount + 10) >= 24)
            {
                HourCount += 10;
                HourCount -= 24;
                DayCount++;
            } else
            {
                HourCount += 10;
            }
        }
    }

    private void ClockFunc()
    {
        if (ClockTime >= 45)
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
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }
    
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = false;
            Vector2 localScale = transform.localScale;
            transform.localScale = localScale;

        }

    }
}
