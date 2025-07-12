using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public float speed = 12f;
    public float horizontal;
    public float jumpPower = 16f;
    private bool isFacingRight = true;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
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
