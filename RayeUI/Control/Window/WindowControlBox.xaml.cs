using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RayeUI.Control.Window
{
    /// <summary>
    /// WindowControlBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowControlBox : UserControl
    {
        public static readonly DependencyProperty MinimizeBoxProperty = DependencyProperty.Register("MinimizeBox", typeof(bool), typeof(WindowControlBox), new PropertyMetadata(true));
        public bool MinimizeBox
        {
            get { return (bool)GetValue(MinimizeBoxProperty); }
            set { SetValue(MinimizeBoxProperty, value); }
        }

        public static readonly DependencyProperty MaximizeBoxProperty = DependencyProperty.Register("MaximizeBox", typeof(bool), typeof(WindowControlBox), new PropertyMetadata(true));
        public bool MaximizeBox
        {
            get { return (bool)GetValue(MaximizeBoxProperty); }
            set { SetValue(MaximizeBoxProperty, value); }
        }

        public readonly static DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(WindowControlBox), new PropertyMetadata(Brushes.Black));
        public Brush Fill
        {
            get
            {
                return (Brush)GetValue(FillProperty);
            }
            set
            {
                SetValue(FillProperty, value);
            }
        }

        public RoutedEventHandler OnMinimize;
        public RoutedEventHandler OnMaximize;
        public RoutedEventHandler OnClose;

        public WindowControlBox()
        {
            InitializeComponent();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (OnMinimize != null)
                OnMinimize(sender, e);
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (OnMaximize != null)
                OnMaximize(sender, e);

            MaximizeButton.ToolTip = (MaximizeIcon.Visibility == Visibility.Visible) ? "이전 크기로 복원" : "최대화";
            RestoreIcon.Visibility = (MaximizeIcon.Visibility == Visibility.Visible) ? Visibility.Visible : Visibility.Hidden;

            MaximizeIcon.Visibility = (MaximizeIcon.Visibility != Visibility.Visible) ? Visibility.Visible : Visibility.Hidden;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            if (OnClose != null)
                OnClose(sender, e);
        }
    }
}
