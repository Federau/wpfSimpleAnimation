using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.BonuceExit
{
    public class BonuceOutDownAnimation : BonuceExitAnimationBase
    {
        public override string AnimationKey { get; set; } = "BonuceOutDown";
        public override void PreProcess(UIElement element)
        {
            TransformGroup group = new TransformGroup();
            ScaleTransform scaleTransform = new ScaleTransform();
            TranslateTransform translateTransform = new TranslateTransform();
            group.Children.Add(scaleTransform);
            group.Children.Add(translateTransform);
            element.RenderTransform = group;
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
    }
    public class BounceOutLeftAnimation : BonuceOutDownAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceOutLeft";
    }
    public class BounceOutRightAnimation : BonuceOutDownAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceOutRight";
    }
    public class BounceOutUpAnimation : BonuceOutDownAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceOutUp";
    }
}
