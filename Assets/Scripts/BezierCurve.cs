using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Transform startPoint;
    public Transform startHandle;
    public Transform endHandle;
    public Transform endPoint;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(startPoint.position, startHandle.position);
        Gizmos.DrawLine(endPoint.position, endHandle.position);

        Gizmos.DrawWireCube(startPoint.position, Vector3.one * 0.1f);
        Gizmos.DrawWireCube(endPoint.position, Vector3.one * 0.1f);

        Gizmos.color = Color.gray;
        Gizmos.DrawLine(startPoint.position, BezierInterpolation(0.5f));
    }

    public Vector3 BezierInterpolation(float t)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        float uuu = uu * u;
        float ttt = tt * t;

        Vector3 p = uuu * startPoint.position; // (1-t)^3 * P0
        p += 3 * uu * t * startHandle.position; // 3(1-t)^2 * t * P1
        p += 3 * u * tt * endHandle.position; // 3(1-t) * t^2 * P2
        p += ttt * endPoint.position; // t^3 * P3

        return p;
    }

    public float ApproximateLength(int numPoints = 10)
    {
        float length = 0f;
        Vector3 lastPoint = BezierInterpolation(0f);

        for (int i = 1; i <= numPoints; i++)
        {
            float t = i / (float)numPoints;
            Vector3 currentPoint = BezierInterpolation(t);
            length += Vector3.Distance(lastPoint, currentPoint);
            lastPoint = currentPoint;
        }

        return length;
    }
}