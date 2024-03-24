using System.Reflection;
using Corby.Option;
using UnityEditor;
using UnityEngine;

namespace Corby.Option.Editor
{
    [CustomPropertyDrawer(typeof(SerializableOption<>), true)]
    public class SerializableOptionPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            var isSome = property.FindPropertyRelative("_isSome");
            var value = property.FindPropertyRelative("_value");

            var isNoneRect = new Rect(position.x, position.y, 20, 20);
            var rect = new Rect(position.x + 20, position.y, position.width - 20, EditorGUI.GetPropertyHeight(value));

            EditorGUI.PropertyField(isNoneRect, isSome, GUIContent.none);

            if (isSome.boolValue)
            {
                var realTypeString = "Some";
                if (value.propertyType == SerializedPropertyType.ObjectReference)
                {
                    realTypeString = value.objectReferenceValue == null ? "None" : "Some";
                }
                label.text = $"{realTypeString} | {label.text}";
                EditorGUI.PropertyField(rect, value, label, true);
            }
            else
            {
                rect = new Rect(position.x + 20, position.y, position.width - 20, position.height);
                label.text = $"None | {label.text}";
                EditorGUI.LabelField(rect, label);
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var isSome = property.FindPropertyRelative("_isSome");
            if (!isSome.boolValue) return base.GetPropertyHeight(property, label);
            
            var value = property.FindPropertyRelative("_value");
            return EditorGUI.GetPropertyHeight(value, label, true);
        }
    }
}