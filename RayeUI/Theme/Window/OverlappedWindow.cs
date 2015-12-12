using RayeUI.Control.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RayeUI.Theme.Window
{
    public class OverlappedWindow : System.Windows.Window
    {
        public static readonly DependencyProperty WindowIconProperty = DependencyProperty.Register("WindowIcon", typeof(UIElement), typeof(OverlappedWindow));
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

        public static readonly DependencyProperty WindowContentProperty = DependencyProperty.Register("WindowContent", typeof(object), typeof(OverlappedWindow));
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

        public static readonly DependencyProperty IsWindowTitleVisibleProperty = DependencyProperty.Register("IsWindowTitleVisible", typeof(bool), typeof(OverlappedWindow), new PropertyMetadata(true));
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

        public readonly static DependencyProperty ResizeBorderThicknessProperty = DependencyProperty.Register("ResizeBorderThickness", typeof(Thickness), typeof(OverlappedWindow), new PropertyMetadata(new Thickness(5)));
        public Thickness ResizeBorderThickness
        {
            get
            {
                return (Thickness)GetValue(ResizeBorderThicknessProperty);
            }
            set
            {
                SetValue(ResizeBorderThicknessProperty, value);
            }
        }

        public OverlappedWindow()
        {
            this.Style = (Style)FindResource("OverlappedWindowStyle");
        }

        public override void OnApplyTemplate()
        {
            var windowControlBox = GetTemplateChild("WindowControlBox") as WindowControlBox;
            windowControlBox.OnMinimize = OnMinimize;
            windowControlBox.OnMaximize = OnMaximize;
            windowControlBox.OnClose = OnClose;

            (GetTemplateChild("Header") as Grid).MouseMove += (sender, e) => { if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed) DragMove(); };

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
