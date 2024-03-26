using System.Reflection;
using Corby.Option;
using UnityEditor;
using UnityEngine;

namespace Corby.Option.Editor
{
    [CustomPropertyDrawer(typeof(Option<>), true)]
    public class OptionPropertyDrawer : PropertyDrawer
    {
        private bool _isSome;
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            var value = property.FindPropertyRelative("Value");
            
            // if (isSome == null || value == null)
            // {
            //     EditorGUI.LabelField(position, label.text, "Add [Serializable] attribute.");
            //     return;
            // }

            var isNoneRect = new Rect(position.x, position.y, 20, 20);
            var rect = new Rect(position.x + 20, position.y, position.width - 20, EditorGUI.GetPropertyHeight(value));

            _isSome = EditorGUI.Toggle(isNoneRect, _isSome);

            if (_isSome)
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
            var value = property.FindPropertyRelative("Value");
            
            if (_isSome || value == null)
            {
                return base.GetPropertyHeight(property, label);
            }
            
            return EditorGUI.GetPropertyHeight(value, label, true);
        }
    }
}