﻿using RayeUI.Control.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RayeUI.Theme.Window
{
    public class RayeWindow : System.Windows.Window
    {
        
        public static readonly DependencyProperty WindowIconProperty = DependencyProperty.Register("WindowIcon", typeof(UIElement), typeof(RayeWindow));
        public UIElement WindowIcon
        {
            get
            {
                return (UIElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(WindowIconProperty, value);
            }
        }

        public static readonly DependencyProperty WindowContentProperty = DependencyProperty.Register("WindowContent", typeof(object), typeof(RayeWindow));
        public object WindowContent
        {
            get
            {
                return GetValue(WindowContentProperty);
            }
            set
            {
                SetValue(WindowContentProperty, value);
            }
        }

        public static readonly DependencyProperty IsWindowTitleVisibleProperty = DependencyProperty.Register("IsWindowTitleVisible", typeof(bool), typeof(RayeWindow), new PropertyMetadata(true));
        public bool IsWindowTitleVisible
        {
            get
            {
                return (bool)GetValue(IsWindowTitleVisibleProperty);
            }
            set
            {
                SetValue(IsWindowTitleVisibleProperty, value);
            }
        }

        public RayeWindow() : base()
        {
            base.Style = (Style)FindResource("RayeWindowStyle");
        }

        public override void OnApplyTemplate()
        {
            var windowControlBox = GetTemplateChild("WindowControlBox") as WindowControlBox;
            windowControlBox.OnMinimize = OnMinimize;
            windowControlBox.OnMaximize = OnMaximize;
            windowControlBox.OnClose = OnClose;

            base.OnApplyTemplate();
        }

        private void OnMinimize(object sender, RoutedEventArgs e)
        {
            base.WindowState = WindowState.Minimized;
        }

        private void OnMaximize(object sender, RoutedEventArgs e)
        {
            base.WindowState = base.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
    }
}