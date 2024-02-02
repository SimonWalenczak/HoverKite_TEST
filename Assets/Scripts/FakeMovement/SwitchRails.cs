using UnityEngine;

enum PlayerType
{
    Player1,
    Player2
}

public class SwitchRails : MonoBehaviour
{
    public LayerMask groundLayer;
    public float RayDistance;
    public Vector3 _offset;
    [SerializeField] private PlayerType playerType;

    void Update()
    {
        if (!Input.GetKey(KeyCode.Space)) return;
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            SwitchFloor(-1f,Vector3.down);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            SwitchFloor(1f, Vector3.up);
        }
    }

    void SwitchFloor(float offset, Vector3 direction)
    {
        RaycastHit hit;
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + offset, transform.position.z), direction, out hit, RayDistance, groundLayer))
        {
            transform.position = hit.point + _offset;
        }

        Debug.DrawRay(transform.position, direction * RayDistance, Color.red, 1f);
    }
}