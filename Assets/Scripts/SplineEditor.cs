using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BezierSpline))]
public class SplineEditor : Editor
{
    private BezierSpline bezierSpline;

    private void OnEnable()
    {
        bezierSpline = target as BezierSpline;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Add Curve"))
        {
            AddCurve();
        }

        if (GUILayout.Button("Remove Last Curve"))
        {
            RemoveLastCurve();
        }
    }

    private void AddCurve()
    {
        BezierCurve newCurve = new GameObject("BezierCurve").AddComponent<BezierCurve>();
        newCurve.transform.parent = bezierSpline.transform;
        bezierSpline.curves.Add(newCurve);
    }

    private void RemoveLastCurve()
    {
        if (bezierSpline.curves.Count > 0)
        {
            BezierCurve lastCurve = bezierSpline.curves[bezierSpline.curves.Count - 1];
            bezierSpline.curves.RemoveAt(bezierSpline.curves.Count - 1);
            DestroyImmediate(lastCurve.gameObject);
        }
    }
}