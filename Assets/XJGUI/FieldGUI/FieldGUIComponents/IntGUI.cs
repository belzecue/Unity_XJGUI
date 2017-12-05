﻿using System.Reflection;

namespace XJGUI.FieldGUIComponents
{
    public class IntGUI : FieldGUIComponent<int>
    {
        #region Constructor

        public IntGUI(System.Object data, FieldInfo fieldInfo, FieldGUIInfo guiInfo)
            : base(data, fieldInfo, guiInfo)
        {
        }

        #endregion Constructor

        #region Method

        protected override void InitializeGUI()
        {
            base.gui = new XJGUI.IntGUI()
            {
                Value = (int)base.fieldInfo.GetValue(base.data),
                Title = base.guiInfo.Title,
                BoldTitle = base.guiInfo.BoldTitle,
                MinValue = (int)base.guiInfo.MinValue,
                MaxValue = (int)base.guiInfo.MaxValue,
            };
        }

        #endregion Method
    }
}