using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public class WoobleAnimation:AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "Wooble";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransform = new RotateTransform();
            element.RenderTransformOrigin = new Point(0.5,5);
        }
    }
}
