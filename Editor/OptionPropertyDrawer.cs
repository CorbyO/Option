using UnityEditor;
using UnityEngine;

namespace Corby.Option.Editor
{
    [CustomPropertyDrawer(typeof(Option<>), true)]
    public class OptionPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            var isSome = property.FindPropertyRelative("IsSome");
            var value = property.FindPropertyRelative("Value");

            if (isSome == null || value == null)
            {
                EditorGUI.LabelField(position, label.text, "Add [Serializable] attribute.");
                return;
            }

            var isNoneRect = new Rect(position.x, position.y, 20, 20);
            var rect = new Rect(position.x + 20, position.y, position.width - 20, EditorGUI.GetPropertyHeight(value));

            bool newIsSome = EditorGUI.Toggle(isNoneRect, isSome.boolValue);
            var isObjectReference = value.propertyType == SerializedPropertyType.ObjectReference;

            if (newIsSome != isSome.boolValue && !newIsSome)
            {
                if (isObjectReference)
                {
                    value.objectReferenceValue = null;
                }
            }

            isSome.boolValue = newIsSome;

            if (isSome.boolValue)
            {
                var realTypeString = "Some";
                if (isObjectReference)
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
            var isSome = property.FindPropertyRelative("IsSome");
            var value = property.FindPropertyRelative("Value");
            
            if (isSome == null || value == null ||
                !isSome.boolValue)
            {
                return base.GetPropertyHeight(property, label);
            }
            
            return EditorGUI.GetPropertyHeight(value, label, true);
        }
    }
}