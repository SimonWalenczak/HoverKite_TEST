using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BezierSpline : MonoBehaviour
{
    public List<BezierCurve> curves = new List<BezierCurve>();

    private void OnDrawGizmos()
    {
        DrawCurves();
    }

    private void DrawCurves()
    {
        foreach (var curve in curves)
        {
            curve.DrawCurve();
        }
    }
}