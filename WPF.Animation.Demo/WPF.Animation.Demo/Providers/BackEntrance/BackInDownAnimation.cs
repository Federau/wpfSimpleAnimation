using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.BackEntrance
{
    public class BackInDownAnimation : BackEntranceAnimationBase
    {
        public override string AnimationKey { get; set; } = "BackInDown";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransformOrigin = new Point(0.5, 0.5);
            TransformGroup group = new TransformGroup();
            group.Children.Add(new ScaleTransform());
            group.Children.Add(new TranslateTransform());
            element.RenderTransform = group;
        }
    }
}
