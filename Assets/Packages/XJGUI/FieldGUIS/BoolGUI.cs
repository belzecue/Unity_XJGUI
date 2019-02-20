﻿using System.Reflection;

namespace XJGUI.FieldGUIs
{
    public class BoolGUI : FieldGUIElement<bool>
    {
        #region Constructor

        public BoolGUI(object data, FieldInfo fieldInfo, FieldGUIInfo guiInfo)
            : base(data, fieldInfo, guiInfo)
        {
            base.gui = new XJGUI.BoolGUI()
            {
                Title = base.GUIInfo.Title,
            };
        }

        #endregion Constructor
    }
}