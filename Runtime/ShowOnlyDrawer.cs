using UnityEngine;
using UnityEditor;

namespace Larzt.Inspector {
  [CustomPropertyDrawer(typeof(ShowOnlyAttribute))]
  public class ShowOnlyDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
      string valueStr;
      switch (property.propertyType) {
        case SerializedPropertyType.Boolean:
          valueStr = property.boolValue.ToString();
          break;
        case SerializedPropertyType.Integer:
          valueStr = property.intValue.ToString();
          break;
        case SerializedPropertyType.Float:
          valueStr = property.floatValue.ToString("0.000");
          break;
        case SerializedPropertyType.String:
          valueStr = property.stringValue;
          break;
        case SerializedPropertyType.Vector2:
          valueStr = property.vector2Value.ToString();
          break;
        case SerializedPropertyType.Vector2Int:
          valueStr = property.vector2IntValue.ToString();
          break;
        case SerializedPropertyType.Vector3:
          valueStr = property.vector3Value.ToString();
          break;
        case SerializedPropertyType.Vector3Int:
          valueStr = property.vector3IntValue.ToString();
          break;
        default:
          valueStr = "(not supported)";
          break;
      }
      EditorGUI.LabelField(position, label.text, valueStr);
    }
  }
}