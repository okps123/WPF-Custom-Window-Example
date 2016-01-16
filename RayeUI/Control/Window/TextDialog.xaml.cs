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
        public string Header { get; set; }
        public string Body { get; set; }

        public TextDialog(string header, string body)
        {
            InitializeComponent();

            this.Header = header;
            this.Body = body;
        }
    }
}
