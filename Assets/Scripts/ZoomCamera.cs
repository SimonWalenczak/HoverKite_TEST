using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public Transform player;
    public Transform beacon1;
    public Transform beacon2;

    public float zoomSpeed = 2.0f;
    public float minFOV = 30f;
    public float maxFOV = 60f;

    public Vector3 Offset;
    
    private Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        if (player == null || beacon1 == null || beacon2 == null || mainCamera == null)
        {
            Debug.LogError("Missing required components. Please assign player, beacon1, beacon2, and Camera.");
        }
    }

    void Update()
    {
        // Calculate the distance between the player and the beacons
        float distanceToBeacons = Vector3.Distance(beacon1.position, beacon2.position);

        // Calculate the distance between the player and the midpoint of the beacons
        float distanceToMidpoint = Vector3.Distance(player.position, (beacon1.position + beacon2.position) / 2);

        // Calculate the desired field of view based on the player's position
        float targetFOV = Mathf.Lerp(minFOV, maxFOV, distanceToMidpoint / distanceToBeacons);

        // Smoothly interpolate between the current field of view and the target field of view
        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, targetFOV, Time.deltaTime * zoomSpeed);

        // Ensure the field of view stays within the specified range
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, maxFOV, minFOV);

        // Update the camera's position to follow the player horizontally
        transform.position = player.position + Offset;
    }
}