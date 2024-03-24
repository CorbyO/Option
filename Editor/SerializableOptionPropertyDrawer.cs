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
            
            if (isSome == null || value == null)
            {
                EditorGUI.LabelField(position, label.text, "Add [Serializable] attribute.");
                return;
            }

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
                label.text = $"{realTypeString} | {property.name}";
                EditorGUI.PropertyField(rect, value, label, true);
            }
            else
            {
                rect = new Rect(position.x + 20, position.y, position.width - 20, position.height);
                label.text = $"None | {property.name}";
                EditorGUI.LabelField(rect, label);
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var isSome = property.FindPropertyRelative("_isSome");
            var value = property.FindPropertyRelative("_value");
            
            if (isSome == null || value == null ||
                !isSome.boolValue)
            {
                return base.GetPropertyHeight(property, label);
            }
            
            return EditorGUI.GetPropertyHeight(value, label, true);
        }
    }
}