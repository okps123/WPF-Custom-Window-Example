using RayeUI.Control.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RayeUI.Theme.Window
{
    public class OverlappedWindow : System.Windows.Window
    {
        public static readonly DependencyProperty WindowHeaderIconProperty = DependencyProperty.Register("WindowHeaderIcon", typeof(UIElement), typeof(OverlappedWindow));
        public UIElement WindowHeaderIcon
        {
            get
            {
                return (UIElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(WindowHeaderIconProperty, value);
            }
        }

        public static readonly DependencyProperty WindowHeaderContentProperty = DependencyProperty.Register("WindowHeaderContent", typeof(object), typeof(OverlappedWindow));
        public object WindowHeaderContent
        {
            get
            {
                return GetValue(WindowHeaderContentProperty);
            }
            set
            {
                SetValue(WindowHeaderContentProperty, value);
            }
        }

        public static readonly DependencyProperty WindowHeaderHeightProperty = DependencyProperty.Register("WindowHeaderHeight", typeof(int), typeof(OverlappedWindow), new PropertyMetadata(30));
        public int WindowHeaderHeight
        {
            get
            {
                return (int)GetValue(WindowHeaderHeightProperty);
            }
            set
            {
                SetValue(WindowHeaderHeightProperty, value);
            }
        }

        public static readonly DependencyProperty WindowHeaderBackgroundProperty = DependencyProperty.Register("WindowHeaderBackground", typeof(Brush), typeof(OverlappedWindow), new PropertyMetadata(Brushes.Transparent));
        public Brush WindowHeaderBackground
        {
            get
            {
                return (Brush)GetValue(WindowHeaderBackgroundProperty);
            }
            set
            {
                SetValue(WindowHeaderBackgroundProperty, value);
            }
        }

        public static readonly DependencyProperty IsWindowHeaderTitleVisibleProperty = DependencyProperty.Register("IsWindowHeaderTitleVisible", typeof(bool), typeof(OverlappedWindow), new PropertyMetadata(true));
        public bool IsWindowHeaderTitleVisible
        {
            get
            {
                return (bool)GetValue(IsWindowHeaderTitleVisibleProperty);
            }
            set
            {
                SetValue(IsWindowHeaderTitleVisibleProperty, value);
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
