using UnityEditor;
using UnityEngine;
using System.Reflection;

/// <summary>
/// Exposing internal Editor stuff
/// </summary>
public static class EditorGUIEx
{
    static int s_CurveHash = "s_CurveHash".GetHashCode();
    static int s_GenericField = "s_GenericField".GetHashCode();
    static int s_FoldoutHash = "Foldout".GetHashCode();

    static FieldInfo _s_PropertyFieldTempContent = typeof(EditorGUI).GetField("s_PropertyFieldTempContent", BindingFlags.Static | BindingFlags.NonPublic);
    public static GUIContent s_PropertyFieldTempContent
    {
        get
        {
            return (GUIContent)_s_PropertyFieldTempContent.GetValue(null);
        }
        set
        {
            _s_PropertyFieldTempContent.SetValue(null, value);
        }
    }

    static FieldInfo _kCurveColor = typeof(EditorGUI).GetField("kCurveColor", BindingFlags.Static | BindingFlags.NonPublic);
    public static Color kCurveColor
    {
        get
        {
            return (Color)_kCurveColor.GetValue(null);
        }
        set
        {
            _kCurveColor.SetValue(null, value);
        }
    }

    static FieldInfo _lastControlID = typeof(EditorGUI).GetField("lastControlID", BindingFlags.Static | BindingFlags.NonPublic);
    public static int lastControlID
    {
        get
        {
            return (int)_lastControlID.GetValue(null);
        }
        set
        {
            _lastControlID.SetValue(null, value);
        }
    }


    static PropertyInfo _lookLikeInspector = typeof(EditorGUIUtility).GetProperty("lookLikeInspector", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
    public static bool lookLikeInspector
    {
        get
        {
            return (bool)_lookLikeInspector.GetValue(null, null);
        }
    }


    static MethodInfo _HasVisibleChildFields = typeof(EditorGUI).GetMethod("HasVisibleChildFields", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(SerializedProperty) }, null);
    public static bool HasVisibleChildFields(SerializedProperty property)
    {
        return (bool)_HasVisibleChildFields.Invoke(null, new object[] { property });
    }

    static MethodInfo _GetSinglePropertyHeight = typeof(EditorGUI).GetMethod("GetSinglePropertyHeight", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static float GetSinglePropertyHeight(SerializedProperty property, GUIContent label)
    {
        return (float)_GetSinglePropertyHeight.Invoke(null, new object[] { property, label });
    }
    public static float GetSinglePropertyHeight(SerializedProperty property)
    {
        return GetSinglePropertyHeight(property, null);
    }

    static MethodInfo _GetControlID = typeof(EditorGUI).GetMethod("GetControlID", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(int), typeof(FocusType), typeof(Rect) }, null);
    public static int GetControlID(int hash, FocusType fType, Rect position)
    {
        return (int)_GetControlID.Invoke(null, new object[] { hash, fType, position });
    }

    static MethodInfo _ValidateObjectFieldAssignment = typeof(EditorGUI).GetMethod("ValidateObjectFieldAssignment", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Object[]), typeof(System.Type), typeof(SerializedProperty) }, null);
    static Object ValidateObjectFieldAssignment(Object[] references, System.Type objType, SerializedProperty property)
    {
        return (Object)_ValidateObjectFieldAssignment.Invoke(null, new object[] { references, objType, property });
    }

    static MethodInfo _ObjectReferenceField = typeof(EditorGUI).GetMethod("ObjectReferenceField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void ObjectReferenceField(Rect position, SerializedProperty property, GUIContent label)
    {
        _ObjectReferenceField.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _ArraySizeField = typeof(EditorGUI).GetMethod("ArraySizeField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(GUIContent), typeof(int), typeof(GUIStyle) }, null);
    public static int ArraySizeField(Rect position, GUIContent label, int value, GUIStyle style)
    {
        return (int)_ArraySizeField.Invoke(null, new object[] { position, label, value, style });
    }

    static MethodInfo _Vector3Field = typeof(EditorGUI).GetMethod("Vector3Field", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void Vector3Field(Rect position, SerializedProperty property, GUIContent label)
    {
        _Vector3Field.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _Popup = typeof(EditorGUI).GetMethod("Popup", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void Popup(Rect position, SerializedProperty property, GUIContent label)
    {
        _Popup.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _LayerMaskField = typeof(EditorGUI).GetMethod("LayerMaskField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void LayerMaskField(Rect position, SerializedProperty property, GUIContent label)
    {
        _LayerMaskField.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _RectField = typeof(EditorGUI).GetMethod("RectField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void RectField(Rect position, SerializedProperty property, GUIContent label)
    {
        _RectField.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _BoundsField = typeof(EditorGUI).GetMethod("BoundsField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(SerializedProperty), typeof(GUIContent) }, null);
    public static void BoundsField(Rect position, SerializedProperty property, GUIContent label)
    {
        _BoundsField.Invoke(null, new object[] { position, property, label });
    }

    static MethodInfo _DoGradientField = typeof(EditorGUI).GetMethod("DoGradientField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(int), typeof(Gradient), typeof(SerializedProperty) }, null);
    public static Gradient DoGradientField(Rect position, int id, Gradient value, SerializedProperty property)
    {
        return (Gradient)_DoGradientField.Invoke(null, new object[] { position, id, value, property });
    }

    static MethodInfo _DoCurveField = typeof(EditorGUI).GetMethod("DoCurveField", BindingFlags.Static | BindingFlags.NonPublic, null, new System.Type[] { typeof(Rect), typeof(int), typeof(AnimationCurve), typeof(Color), typeof(Rect), typeof(SerializedProperty) }, null);
    public static AnimationCurve DoCurveField(Rect position, int id, AnimationCurve value, Color color, Rect ranges, SerializedProperty property)
    {
        return (AnimationCurve)_DoCurveField.Invoke(null, new object[] { position, id, value, color, ranges, property });
    }


    static MethodInfo _AppendFoldoutPPtrValue = typeof(SerializedProperty).GetMethod("AppendFoldoutPPtrValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new System.Type[] { typeof(Object) }, null);
    public static void AppendFoldoutPPtrValue(this SerializedProperty p, Object obj)
    {
        _AppendFoldoutPPtrValue.Invoke(p, new object[] { obj });
    }


    public static void SetExpandedRecurse(SerializedProperty property, bool expanded)
    {
        SerializedProperty serializedProperty = property.Copy();
        serializedProperty.isExpanded = expanded;
        int depth = serializedProperty.depth;
        while (serializedProperty.NextVisible(true) && serializedProperty.depth > depth)
        {
            if (serializedProperty.hasVisibleChildren)
            {
                serializedProperty.isExpanded = expanded;
            }
        }
    }


    public static bool SinglePropertyField(Rect position, SerializedProperty property, GUIContent label)
    {
        //PropertyDrawer drawer = PropertyDrawer.GetDrawer(property);
        //if (drawer != null)
        //{
        //    EditorLook look = EditorGUIUtility.look;
        //    float labelWidth = EditorGUIUtility.labelWidth;
        //    float fieldWidth = EditorGUI.kNumberW;
        //    drawer.OnGUI(position, property.Copy(), label ?? EditorGUIUtility.TempContent(property.displayName));
        //    if (EditorGUIUtility.look != look)
        //    {
        //        if (look == EditorLook.LikeControls)
        //        {
        //            EditorGUIUtility.LookLikeControls(labelWidth, fieldWidth);
        //        }
        //        else
        //        {
        //            EditorGUIUtility.LookLikeInspector();
        //        }
        //    }
        //    EditorGUIUtility.labelWidth = labelWidth;
        //    EditorGUI.kNumberW = fieldWidth;
        //    return false;
        //}
        label = EditorGUI.BeginProperty(position, label, property);
        SerializedPropertyType propertyType = property.propertyType;
        bool flag = false;
        if (!HasVisibleChildFields(property))
        {
            switch (propertyType)
            {
                case SerializedPropertyType.Integer:
                    {
                        EditorGUI.BeginChangeCheck();
                        int intValue = EditorGUI.IntField(position, label, property.intValue);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.intValue = intValue;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.Boolean:
                    {
                        EditorGUI.BeginChangeCheck();
                        bool boolValue = EditorGUI.Toggle(position, label, property.boolValue);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.boolValue = boolValue;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.Float:
                    {
                        EditorGUI.BeginChangeCheck();
                        float floatValue = EditorGUI.FloatField(position, label, property.floatValue);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.floatValue = floatValue;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.String:
                    {
                        EditorGUI.BeginChangeCheck();
                        string stringValue = EditorGUI.TextField(position, label, property.stringValue);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.stringValue = stringValue;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.Color:
                    {
                        EditorGUI.BeginChangeCheck();
                        Color colorValue = EditorGUI.ColorField(position, label, property.colorValue);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.colorValue = colorValue;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.ObjectReference:
                    ObjectReferenceField(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.LayerMask:
                    LayerMaskField(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.Enum:
                    Popup(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.Vector3:
                    Vector3Field(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.Rect:
                    RectField(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.ArraySize:
                    {
                        EditorGUI.BeginChangeCheck();
                        int intValue2 = ArraySizeField(position, label, property.intValue, EditorStyles.numberField);
                        if (EditorGUI.EndChangeCheck())
                        {
                            property.intValue = intValue2;
                        }
                        goto IL_326;
                    }
                case SerializedPropertyType.Character:
                    {
                        char[] value = new char[]
                            {
                                (char)property.intValue
                            };
                        bool changed = GUI.changed;
                        GUI.changed = false;
                        string text = EditorGUI.TextField(position, label, new string(value));
                        if (GUI.changed)
                        {
                            if (text.Length == 1)
                            {
                                property.intValue = (int)text[0];
                            }
                            else
                            {
                                GUI.changed = false;
                            }
                        }
                        GUI.changed |= changed;
                        goto IL_326;
                    }
                case SerializedPropertyType.AnimationCurve:
                    {
                        int controlID = GetControlID(s_CurveHash, EditorGUIUtility.native, position);
                        DoCurveField(EditorGUI.PrefixLabel(position, controlID, label), controlID, null, kCurveColor, default(Rect), property);
                        goto IL_326;
                    }
                case SerializedPropertyType.Bounds:
                    BoundsField(position, property, label);
                    goto IL_326;
                case SerializedPropertyType.Gradient:
                    {
                        int controlID2 = GetControlID(s_CurveHash, EditorGUIUtility.native, position);
                        DoGradientField(EditorGUI.PrefixLabel(position, controlID2, label), controlID2, null, property);
                        goto IL_326;
                    }
            }
            int controlID3 = GetControlID(s_GenericField, FocusType.Keyboard, position);
            EditorGUI.PrefixLabel(position, controlID3, label);
        IL_326: ;
        }
        else
        {
            int controlID4 = GetControlID(s_FoldoutHash, FocusType.Passive, position);
            EventType type = Event.current.type;
            if (type != EventType.DragUpdated && type != EventType.DragPerform)
            {
                if (type == EventType.DragExited)
                {
                    if (GUI.enabled)
                    {
                        HandleUtility.Repaint();
                    }
                }
            }
            else
            {
                if (position.Contains(Event.current.mousePosition) && GUI.enabled)
                {
                    Object[] objectReferences = DragAndDrop.objectReferences;
                    Object[] array = new Object[1];
                    bool flag2 = false;
                    Object[] array2 = objectReferences;
                    for (int i = 0; i < array2.Length; i++)
                    {
                        Object @object = array2[i];
                        array[0] = @object;
                        Object object2 = ValidateObjectFieldAssignment(array, null, property);
                        if (object2 != null)
                        {
                            DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                            if (Event.current.type == EventType.DragPerform)
                            {
                                property.AppendFoldoutPPtrValue(object2);
                                flag2 = true;
                                DragAndDrop.activeControlID = 0;
                            }
                            else
                            {
                                DragAndDrop.activeControlID = controlID4;
                            }
                        }
                    }
                    if (flag2)
                    {
                        GUI.changed = true;
                        DragAndDrop.AcceptDrag();
                        Event.current.Use();
                    }
                }
            }
            flag = property.isExpanded;
            if (lookLikeInspector)
            {
                int num = EditorStyles.foldout.padding.left - EditorStyles.label.padding.left;
                position.x -= (float)num;
                position.width += (float)num;
            }
            GUI.enabled &= property.editable;
            GUIStyle style = (DragAndDrop.activeControlID != -10) ? EditorStyles.foldout : EditorStyles.foldoutPreDrop;
            bool flag3 = EditorGUI.Foldout(position, flag, s_PropertyFieldTempContent, true, style);
            if (flag3 != flag)
            {
                if (Event.current.alt)
                {
                    SetExpandedRecurse(property, flag3);
                }
                else
                {
                    property.isExpanded = flag3;
                }
            }
            flag = flag3;
        }
        EditorGUI.EndProperty();
        if (Event.current.type == EventType.ExecuteCommand || Event.current.type == EventType.ValidateCommand)
        {
            if (GUIUtility.keyboardControl == lastControlID && (Event.current.commandName == "Delete" || Event.current.commandName == "SoftDelete"))
            {
                if (Event.current.type == EventType.ExecuteCommand)
                {
                    property.DeleteCommand();
                }
                Event.current.Use();
            }
            if (GUIUtility.keyboardControl == lastControlID && Event.current.commandName == "Duplicate")
            {
                if (Event.current.type == EventType.ExecuteCommand)
                {
                    property.DuplicateCommand();
                }
                Event.current.Use();
            }
        }
        return flag;
    }

    public static bool SinglePropertyField(Rect position, SerializedProperty property)
    {
        return SinglePropertyField(position, property, null);
    }

    public static bool PropertyField(Rect position, SerializedProperty property, GUIContent label)
    {
        Vector2 iconSize = EditorGUIUtility.GetIconSize();
        if (lookLikeInspector)
        {
            EditorGUIUtility.SetIconSize(new Vector2(16f, 16f));
        }
        bool enabled = GUI.enabled;
        int indentLevel = EditorGUI.indentLevel;
        int num = indentLevel - property.depth;
        position.height = 16f;
        SerializedProperty serializedProperty = property.Copy();
        SerializedProperty endProperty = serializedProperty.GetEndProperty();
        EditorGUI.indentLevel = serializedProperty.depth + num;
        bool enterChildren = SinglePropertyField(position, serializedProperty, label) && HasVisibleChildFields(serializedProperty);
        position.y += GetSinglePropertyHeight(serializedProperty);
        while (serializedProperty.NextVisible(enterChildren) && !SerializedProperty.EqualContents(serializedProperty, endProperty))
        {
            EditorGUI.indentLevel = serializedProperty.depth + num;
            EditorGUI.BeginChangeCheck();
            enterChildren = (SinglePropertyField(position, serializedProperty) && HasVisibleChildFields(serializedProperty));
            if (EditorGUI.EndChangeCheck())
            {
                break;
            }
            position.y += GetSinglePropertyHeight(serializedProperty);
        }
        GUI.enabled = enabled;
        EditorGUIUtility.SetIconSize(iconSize);
        EditorGUI.indentLevel = indentLevel;
        return false;
    }

    static public float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        //PropertyDrawer drawer = PropertyDrawer.GetDrawer(property);
        //if (drawer != null)
        //{
        //    return drawer.GetPropertyHeight(property.Copy(), label ?? EditorGUIUtility.TempContent(property.displayName));
        //}
        property = property.Copy();
        SerializedProperty endProperty = property.GetEndProperty();
        float height = EditorGUIEx.GetSinglePropertyHeight(property, label);
        bool enterChildren = property.isExpanded && EditorGUIEx.HasVisibleChildFields(property);
        while (property.NextVisible(enterChildren) && !SerializedProperty.EqualContents(property, endProperty))
        {
            //drawer = PropertyDrawer.GetDrawer(property);
            //if (drawer != null)
            //{
            //    height += drawer.GetPropertyHeight(property.Copy(), EditorGUIUtility.TempContent(property.displayName));
            //    enterChildren = false;
            //}
            //else
            {
                height += EditorGUIEx.GetSinglePropertyHeight(property);
                enterChildren = (property.isExpanded && EditorGUIEx.HasVisibleChildFields(property));
            }
        }
        return height;
    }
}

[CustomPropertyDrawer(typeof(Tooltip))]
public class TooltipDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Tooltip tooltipAttribute = attribute as Tooltip;
        label.tooltip = tooltipAttribute.text;

        EditorGUIEx.PropertyField(position, property, label);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIEx.GetPropertyHeight(property, label);
    }
}
