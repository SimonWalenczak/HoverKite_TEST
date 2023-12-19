using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Transform[] controlPoints;
    public int resolution = 10;

    private void OnDrawGizmos()
    {
        DrawCurve();
    }

    public void DrawCurve()
    {
        for (int i = 0; i < resolution; i++)
        {
            float t = i / (float)(resolution - 1);
            Vector3 point = CalculateBezierPoint(t, controlPoints);
            Gizmos.DrawSphere(point, 0.1f);
        }
    }

    private Vector3 CalculateBezierPoint(float t, Transform[] points)
    {
        int order = points.Length - 1;
        Vector3[] tempPoints = new Vector3[points.Length];

        for (int i = 0; i <= order; i++)
        {
            tempPoints[i] = points[i].position;
        }

        for (int r = 1; r <= order; r++)
        {
            for (int i = 0; i <= order - r; i++)
            {
                tempPoints[i] = (1 - t) * tempPoints[i] + t * tempPoints[i + 1];
            }
        }

        return tempPoints[0];
    }
}