using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform[] players;  
    public float minZoom = 5f;   
    public float maxZoom = 20f;  
    public float zoomSpeed = 5f; 
    public float followSpeed = 5f; 
    public Vector3 cameraOffset = new Vector3(0f, 5f, -10f);

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (players.Length == 0)
            return;

        Bounds bounds = CalculatePlayersBounds();

        Vector3 targetPosition = bounds.center + cameraOffset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * followSpeed);

        float targetZoom = Mathf.Clamp(bounds.size.x, minZoom, maxZoom);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetZoom, Time.deltaTime * zoomSpeed);
    }

    Bounds CalculatePlayersBounds()
    {
        if (players.Length == 1)
        {
            return new Bounds(players[0].position, Vector3.zero);
        }

        Bounds bounds = new Bounds(players[0].position, Vector3.zero);

        for (int i = 1; i < players.Length; i++)
        {
            bounds.Encapsulate(players[i].position);
        }

        return bounds;
    }
}