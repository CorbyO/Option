using Corby.Option;
using UnityEditor;
using UnityEngine;

namespace Corny.Editor
{
    
    [CustomPropertyDrawer(typeof(SerializableOption), true)]
    public class SerializableOptionPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            var isSome = property.FindPropertyRelative("IsSome");
            var value = property.FindPropertyRelative("_value");
            
            var isNoneRect = new Rect(position.x, position.y, 20, position.height);
            var rect = new Rect(position.x + 20, position.y, position.width - 20, position.height);
            
            EditorGUI.PropertyField(isNoneRect, isSome, GUIContent.none);
            
            if (isSome.boolValue)
            {
                label.text = $"{label.text} (Some)";
                EditorGUI.PropertyField(rect, value, label);
            }
            else
            {
                label.text = $"{label.text} (None)";
                EditorGUI.LabelField(rect, label);
            }
            
            
            EditorGUI.EndProperty();
        }
    }
}