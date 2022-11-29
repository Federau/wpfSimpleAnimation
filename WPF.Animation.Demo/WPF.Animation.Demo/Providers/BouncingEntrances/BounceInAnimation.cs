using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPF.Animation.Demo.Providers.BouncingEntrances
{
    public class BounceInAnimation : BounceEntranceAnimationBase
    {
        public override string AnimationKey { get; set; } = "BonuceIn";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransform = new ScaleTransform();
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
    }
    public class BounceInDownAnimation : BounceEntranceAnimationBase
    {
        public override string AnimationKey { get; set; } = "BonuceInDown";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransform = new TranslateTransform();
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
        protected override void ApplyDetail(object resources, UIElement element)
        {
            element.RenderTransform.BeginAnimation(TranslateTransform.YProperty, resources as DoubleAnimation);
        }
    }
    public class BounceInLeftAnimation : BounceInDownAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceInLeft";
        protected override void ApplyDetail(object resources, UIElement element)
        {
            element.RenderTransform.BeginAnimation(TranslateTransform.XProperty, resources as DoubleAnimation);
        }
    }
    public class BounceInRightAnimation : BounceInLeftAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceInRight";
    }
    public class BounceInUpAnimation : BounceInDownAnimation
    {
        public override string AnimationKey { get; set; } = "BonuceInUp";
    }
}
