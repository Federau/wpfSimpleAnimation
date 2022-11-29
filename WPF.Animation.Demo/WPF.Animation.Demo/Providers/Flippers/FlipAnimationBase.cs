using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.Flippers
{
    public abstract class FlipAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "Flip";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransformOrigin = new Point(0.5, 0.5);
            element.RenderTransform = new ScaleTransform();
        }
    }
    public class FlipAnimation : FlipAnimationBase
    {
        public override string AnimationKey { get; set; } = "Flip";
    }
    public class FlipInXAnimation : FlipAnimationBase
    {
        public override string AnimationKey { get; set; } = "FlipInX";
    }
    public class FlipInYAnimation : FlipAnimationBase
    {
        public override string AnimationKey { get; set; } = "FlipInY";
    }
    public class FlipOutXAnimation : FlipAnimationBase
    {
        public override string AnimationKey { get; set; } = "FlipOutX";
    }
    public class FlipOutYAnimation : FlipAnimationBase
    {
        public override string AnimationKey { get; set; } = "FlipOutY";
    }
}
