﻿using System.Reflection;

namespace XJGUI
{
    public abstract class FieldGUIBase
    {
        #region Property

        protected System.Object data;
        protected FieldInfo fieldInfo;
        protected FieldGUIInfo guiInfo;

        #endregion Property

        #region Constructor

        public FieldGUIBase(System.Object data, FieldInfo fieldInfo, FieldGUIInfo guiInfo)
        {
            this.data = data;
            this.fieldInfo = fieldInfo;
            this.guiInfo = guiInfo;

            InitializeGUI();
            Load();
        }

        #endregion Constrcutor

        #region Method

        protected abstract void InitializeGUI();

        protected abstract void Save();

        protected abstract void Load();

        protected abstract void ShowGUI();

        public void Show()
        {
            ShowGUI();
            Save();
        }

        #endregion Method
    }
}