using UnityEngine;

public class RotateToSurface : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5.0f;

    private void Update()
    {
        RotateToGround();
    }

    private void RotateToGround()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.0f))
        {
            Vector3 groundNormal = hit.normal;

            Quaternion targetRotation = Quaternion.FromToRotation(transform.up, groundNormal) * transform.rotation;

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }
}