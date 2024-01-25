using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRails : MonoBehaviour
{
    public LayerMask groundLayer; // Layer mask for the ground
    public LayerMask secondFloorLayer; // Layer mask for the second floor

    public bool isOnGroundFloor = true; // Flag to track the character's current floor

    void Update()
    {
        // Check for input to trigger floor switch
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchFloor();
        }
    }

    void SwitchFloor()
    {
        // Set the raycast direction based on the current floor
        Vector3 raycastDirection = isOnGroundFloor ? Vector3.up : Vector3.down;

        // Cast a ray from the character's position in the specified direction
        RaycastHit hit;
        if (Physics.Raycast(transform.position, raycastDirection, out hit, Mathf.Infinity, isOnGroundFloor ? groundLayer : secondFloorLayer))
        {
            // Teleport the character to the hit point
            transform.position = hit.point;

            // Update the current floor flag
            isOnGroundFloor = !isOnGroundFloor;
        }
        
        Debug.DrawRay(transform.position, raycastDirection * 10f, Color.red, 1f);
    }
}
