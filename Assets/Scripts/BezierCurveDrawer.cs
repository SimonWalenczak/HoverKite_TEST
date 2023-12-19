using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BezierCurve))]
public class BezierCurveDrawer : Editor
{
    private void OnSceneGUI()
    {
        BezierCurve curve = target as BezierCurve;

        Handles.color = Color.green;
        Handles.DrawBezier(
            curve.startPoint.position,
            curve.endPoint.position,
            curve.startHandle.position,
            curve.endHandle.position,
            Color.green,
            null,
            2f
        );

        Handles.DrawWireCube(curve.startHandle.position, Vector3.one * 0.1f);
        Handles.DrawWireCube(curve.endHandle.position, Vector3.one * 0.1f);

        Handles.Label(curve.startPoint.position, "Start Point");
        Handles.Label(curve.endPoint.position, "End Point");

        EditorGUI.BeginChangeCheck();

        Vector3 newStartHandlePos = Handles.PositionHandle(curve.startHandle.position, Quaternion.identity);
        Vector3 newEndHandlePos = Handles.PositionHandle(curve.endHandle.position, Quaternion.identity);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(curve, "Change Bezier Curve");
            curve.startHandle.position = newStartHandlePos;
            curve.endHandle.position = newEndHandlePos;
            EditorUtility.SetDirty(curve);
        }
    }
}