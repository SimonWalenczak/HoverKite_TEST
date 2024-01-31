using UnityEngine;

enum ColorType
{
    Red,
    Blue,
    Green,
    Yellow
}

public class PlayerRay : MonoBehaviour
{
    private Vector3 _originRay;
    [SerializeField] ColorType _colorType;

    private Color _colorPlayer;

    private void Start()
    {
        switch (_colorType)
        {
            case ColorType.Red:
                _colorPlayer = Color.red;
                break;
            case ColorType.Blue:
                _colorPlayer = Color.blue;
                break;
            case ColorType.Green:
                _colorPlayer = Color.green;
                break;
            case ColorType.Yellow:
                _colorPlayer = Color.yellow;
                break;
        }
    }

    private void Update()
    {
        _originRay = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.DrawRay(_originRay, Vector3.up * 20, _colorPlayer, 1f);
        Debug.DrawRay(_originRay, Vector3.down * 20, _colorPlayer, 1f);
    }
}