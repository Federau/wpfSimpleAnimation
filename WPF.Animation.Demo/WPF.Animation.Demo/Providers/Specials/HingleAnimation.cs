using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.Specials
{
    public class HingleAnimation : SpecialAnimationBase
    {
        public override string AnimationKey { get; set; } = "Hingle";
        public override void PreProcess(UIElement element)
        {
            TransformGroup group = new TransformGroup();
            group.Children.Add(new RotateTransform());
            group.Children.Add(new TranslateTransform());
            element.RenderTransform = group;
            element.RenderTransformOrigin = new Point(0, 0);
        }
    }
}
