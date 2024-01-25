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

    void MoveForward()
    {
        Vector3 forwardMovement = transform.forward * forwardSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMovement);
    }
    
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}