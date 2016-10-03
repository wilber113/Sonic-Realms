﻿using UnityEditor;
using UnityEngine;

namespace SonicRealms.Core.Utils.Editor
{
    [CustomPropertyDrawer(typeof(AddIndentLevelAttribute))]
    public class AddIndentLevelDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            var attr = (AddIndentLevelAttribute) attribute;
            EditorGUI.indentLevel += attr.Amount;
        }

        public override float GetHeight()
        {
            return 0;
        }
    }
}