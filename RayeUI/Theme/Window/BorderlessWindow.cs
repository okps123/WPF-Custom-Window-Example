using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace RayeUI.Theme.Window
{
    public class BorderlessWindow : System.Windows.Window
    {
        public readonly static DependencyProperty CaptionHeightProperty = DependencyProperty.Register("CaptionHeight", typeof(int), typeof(BorderlessWindow), new PropertyMetadata(0));
        public int CaptionHeight
        {
            get
            {
                return (int)GetValue(CaptionHeightProperty);
            }
            set
            {
                SetValue(CaptionHeightProperty, value);
            }
        }

        public readonly static DependencyProperty ResizeBorderThicknessProperty = DependencyProperty.Register("ResizeBorderThickness", typeof(Thickness), typeof(BorderlessWindow), new PropertyMetadata(new Thickness(5)));
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

        public readonly static DependencyProperty GlassFrameThicknessProperty = DependencyProperty.Register("GlassFrameThickness", typeof(Thickness), typeof(BorderlessWindow), new PropertyMetadata(new Thickness(0,0,0,1)));
        public Thickness GlassFrameThickness
        {
            get
            {
                return (Thickness)GetValue(GlassFrameThicknessProperty);
            }
            set
            {
                SetValue(GlassFrameThicknessProperty, value);
            }
        }

        public BorderlessWindow() :base()
        {
            base.Style = (Style)FindResource("BorderlessWindowStyle");
        }
    }
}
