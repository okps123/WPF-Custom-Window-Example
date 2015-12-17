using RayeUI.Theme.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RayeUI.Control.Window
{
    /// <summary>
    /// TextDialog.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TextDialog : RayeWindow
    {
        public TextDialog(string head, string body)
        {
            InitializeComponent();
            base.MinimizeBox = false;
            base.MaximizeBox = false;
        }
    }
}
