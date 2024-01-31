using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z + offset.z);
    }
}