using UnityEngine;

public class RailCharacterController : MonoBehaviour
{
    public float forwardSpeed = 5f;          // Forward movement speed
    public float acceleration = 2f;          // Acceleration on slopes
    public float jumpForce = 10f;            // Force applied when jumping
    public Transform groundCheck;            // Transform representing the position for ground checking
    public LayerMask groundLayer;            // LayerMask for detecting the ground

    private Rigidbody rb;
    [SerializeField] private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (groundCheck == null)
        {
            Debug.LogError("Ground check transform not assigned in the inspector!");
        }
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, 0.1f, groundLayer);

        // Auto-forward movement
        MoveForward();

        // Jumping
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        // Acceleration on slopes
        ApplyAccelerationOnSlopes();
    }

    void MoveForward()
    {
        Vector3 forwardMovement = transform.forward * forwardSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMovement);
    }

    void ApplyAccelerationOnSlopes()
    {
        if (isGrounded)
        {
            float slopeAngle = Vector3.Angle(Vector3.up, GetGroundNormal());
            float accelerationMultiplier = Mathf.Lerp(1f, acceleration, slopeAngle / 45f); // Adjust 45 as needed

            Vector3 accelerationForce = transform.forward * accelerationMultiplier;
            rb.AddForce(accelerationForce, ForceMode.Acceleration);
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    Vector3 GetGroundNormal()
    {
        RaycastHit hit;
        Physics.Raycast(groundCheck.position, Vector3.down, out hit, 0.1f, groundLayer);
        return hit.normal;
    }
}