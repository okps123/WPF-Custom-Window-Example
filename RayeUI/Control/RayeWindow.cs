using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RayeUI.Control
{
    public class RayeWindow : Window
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

        public RayeWindow() : base()
        {
            base.Style = (Style)FindResource("RayeWindowStyle");
        }
        
        public override void OnApplyTemplate()
        {
            var minimizeButton = GetTemplateChild("MinimizeButton") as Button;

            if (minimizeButton != null)
                minimizeButton.Click += OnMinimize;

            var maximizeButton = GetTemplateChild("MaximizeButton") as Button;

            if (maximizeButton != null)
                maximizeButton.Click += OnMaximize;

            var closeButton = GetTemplateChild("CloseButton") as Button;

            if (closeButton != null)
                closeButton.Click += OnClose;

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
