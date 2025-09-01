using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Borders : MonoBehaviour
{
    public float radius;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Borders))]
public class CircleHandle2DEditor : Editor
{
    void OnSceneGUI()
    {
        Borders circleHandle = (Borders)target;
        Transform t = circleHandle.transform;

        // Center of the circle (object's position)
        Vector3 center = t.position;

        Handles.color = Color.yellow;

        EditorGUI.BeginChangeCheck();

        // Draw interactive circular handle
        float newRadius = Handles.RadiusHandle(Quaternion.identity, center, circleHandle.radius);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(circleHandle, "Change Radius");
            circleHandle.radius = newRadius;
        }

        Handles.DrawWireDisc(center, Vector3.forward, circleHandle.radius);
    }
}
#endif