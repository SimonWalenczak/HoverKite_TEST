using UnityEngine;

public class RailCharacterController : MonoBehaviour
{
    public float forwardSpeed = 5f;          
    public float acceleration = 2f;         
    public float jumpForce = 10f;          
    public Transform groundCheck;           
    public LayerMask groundLayer;          
    public LayerMask BumperLayer;          

    private Rigidbody rb;
    [SerializeField] private bool isGrounded;
    
    private void OnTriggerEnter(Collider other)
    {
        if (Contains(BumperLayer, other.gameObject.layer))
        {
            Jump();
        }
    }
    private static bool Contains(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }
    
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
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, 0.1f, groundLayer);

        MoveForward();
    }

    void FixedUpdate()
    {
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
            float accelerationMultiplier = Mathf.Lerp(1f, acceleration, slopeAngle / 45f);

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