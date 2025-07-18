using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class YellowKnightController : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float sprintSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 input;
    private bool isSprinting;

    private string currentAnim = "";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Input
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input = input.normalized;

        // Sprint check
        isSprinting = Input.GetKey(KeyCode.LeftShift);

        // Choose animation based on direction + speed
        HandleAnimations();
    }

    void FixedUpdate()
    {
        float speed = isSprinting ? sprintSpeed : walkSpeed;
        rb.velocity = input * speed;
    }

    void HandleAnimations()
    {
        if (input == Vector2.zero)
        {
            animator.Play(""); // Play empty or Idle if you want
            currentAnim = "";
            return;
        }

        bool movingRight = input.x > 0;
        bool movingLeft = input.x < 0;

        string nextAnim = "";

        if (isSprinting)
        {
            if (movingRight)
                nextAnim = "yellow knight run right";
            else if (movingLeft)
                nextAnim = "yellow knight run left";
        }
        else
        {
            if (movingRight)
                nextAnim = "yellow knight walk right";
            else if (movingLeft)
                nextAnim = "yellow knight walk left";
        }

        // Prevent restarting the animation every frame
        if (nextAnim != "" && nextAnim != currentAnim)
        {
            animator.Play(nextAnim);
            currentAnim = nextAnim;
        }
    }
}
