using UnityEngine;

public class DetectRail : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _raycastDistance = 1.0f;
    [SerializeField] private float _offset = 0.1f;

    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _raycastDistance, _groundLayer))
        {
            Vector3 newPosition = hit.point + new Vector3(0f, _offset, 0f);
            transform.position = newPosition;

            Quaternion rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
            transform.rotation = rotation;
        }
        
        Debug.DrawRay(transform.position, Vector3.down * _raycastDistance, Color.red, 1f);
    }
}