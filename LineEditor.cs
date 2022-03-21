using UnityEngine;
using UnityEditor;

//Attach Editor to Line component
[CustomEditor(typeof(Line))]

public class NewBehaviourScript : Editor
{
    private void OnSceneGUI()
    {
        //Get the game object being inspected
        Line line = target as Line;
        if (line == null)
        {
            Debug.Log("LineEditor::line == null");
            return;
        }

        //Transform points from local to world space
        Transform lineTransform = line.transform;
        Vector3 p0 = lineTransform.TransformPoint(line.P0);
        Vector3 p1 = lineTransform.TransformPoint(line.P1);

        //Set the line color
        Handles.color = Color.red;

        //Draw the line
        Handles.DrawLine(p0, p1);

        //Create position handle in scene
        Quaternion handleRotation = Quaternion.identity;
        p0 = Handles.PositionHandle(p0, handleRotation);
        p1 = Handles.PositionHandle(p1, handleRotation);

        //Check if position changed
        EditorGUI.BeginChangeCheck();

        //Get new position
        p0 = Handles.PositionHandle(p0, handleRotation);
        if(EditorGUI.EndChangeCheck())
        {
            //mark the object as changed
            Undo.RecordObject(line, "Move Point");
            line.P0 = lineTransform.InverseTransformPoint(p0);
        }

        p1 = Handles.PositionHandle(p1 , handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            //mark the object as changed
            Undo.RecordObject(line, "Move Point");
            line.P1 = lineTransform.InverseTransformPoint(p1);
        }
    }
}
