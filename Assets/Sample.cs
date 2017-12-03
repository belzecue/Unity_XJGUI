﻿using UnityEngine;
using XJGUI;

public class Sample : MonoBehaviour
{
    public enum SampleEnum
    {
        value1,
        value2,
    }

    FlexibleWindow flexibleWindow;

    TabPanel tabPanel;
    FoldoutPanel foldOutPanel;

    BoolGUI boolGUI;
    IntGUI intGUI;
    FloatGUI floatGUI;
    EnumGUI<SampleEnum> enumGUI;

    Vector2GUI vector2GUI;

    Toolbar toolBar;
    IPv4GUI ipv4GUI;

    void Start()
    {
        this.flexibleWindow = new FlexibleWindow()
        {
            MinWidth  = 300,
            MinHeight = 300,
        };

        this.tabPanel = new TabPanel() { Labels = new string[] { "Value", "Else" } };

        this.foldOutPanel = new FoldoutPanel() { Title = "Vector", Value = false };

        this.boolGUI = new BoolGUI() { Title = "Bool Value", BoldTitle = true, Value = false };

        this.intGUI = new IntGUI() { Title = "int Value", MinValue = 0, MaxValue = 100, };

        this.floatGUI = new FloatGUI() { Title = "float Value", Value = 50, MinValue = 0, MaxValue = 100, Decimals = 3, };

        this.enumGUI = new EnumGUI<SampleEnum>() { Value = SampleEnum.value2, Title = "Sample Enum Value", ButtonWidth = 100 };

        this.vector2GUI = new Vector2GUI() { Value = new Vector2(0.5f, 0.5f), Title = "Vector2 Value", Decimals = 1, MinValue = new Vector2(-1, -1), MaxValue = new Vector2(1, 1), Horizontal = false };

        this.toolBar = new Toolbar() { Title = "Toolbar", Labels = new string[] { "A", "B", "C" } };

        this.ipv4GUI = new IPv4GUI() { Title = "IPV4", Value = "7.7.7.7", };
    }

    void OnGUI()
    {
        this.flexibleWindow.Show(() =>
        {
            this.tabPanel.Show(() =>
            {
                this.boolGUI.Show();
                this.intGUI.Show();
                this.floatGUI.Show();
                this.enumGUI.Show();

                this.foldOutPanel.Show(() =>
                {
                    this.vector2GUI.Show();
                });

                this.toolBar.Show();
                this.ipv4GUI.Show();
            });
        });
    }
}