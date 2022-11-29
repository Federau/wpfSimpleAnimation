using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public class TadaAnimation : AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "Tada";
        public override void PreProcess(UIElement element)
        {
            var group = new TransformGroup();
            group.Children.Add(new ScaleTransform());
            group.Children.Add(new RotateTransform());
            element.RenderTransform = group;
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
    }
}
