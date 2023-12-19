using UnityEngine;

public class CharacterFollowBezierCurve : MonoBehaviour
{
    public BezierCurve bezierCurve;
    public float speed = 2.0f;
    public float rotationSpeed = 5.0f;

    private float t = 0f;

    private void Update()
    {
        if (bezierCurve != null)
        {
            MoveAlongCurve();
        }
    }

    private void MoveAlongCurve()
    {
        t += Time.deltaTime * speed / bezierCurve.ApproximateLength();

        if (t > 1f)
        {
            t = 1f;
        }

        Vector3 positionOnCurve = bezierCurve.BezierInterpolation(t);
        transform.position = positionOnCurve;

        // Rotate the character to align with the curve direction
        if (t < 1f)
        {
            Vector3 nextPosition = bezierCurve.BezierInterpolation(t + 0.01f);
            Vector3 direction = nextPosition - positionOnCurve;
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * rotationSpeed);
        }
    }
}