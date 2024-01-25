using UnityEngine;

public class SwitchRails : MonoBehaviour
{
    public LayerMask groundLayer;
    public LayerMask secondFloorLayer;

    public bool isOnGroundFloor = true; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchFloor();
        }
    }

    void SwitchFloor()
    {
        Vector3 raycastDirection = isOnGroundFloor ? Vector3.up : Vector3.down;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, raycastDirection, out hit, Mathf.Infinity, isOnGroundFloor ? groundLayer : secondFloorLayer))
        {
            transform.position = hit.point;

            isOnGroundFloor = !isOnGroundFloor;
        }
        
        Debug.DrawRay(transform.position, raycastDirection * 10f, Color.red, 1f);
    }
}
