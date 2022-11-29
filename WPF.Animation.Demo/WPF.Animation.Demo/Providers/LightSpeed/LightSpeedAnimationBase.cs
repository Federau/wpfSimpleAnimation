using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.LightSpeed
{
    public abstract class LightSpeedAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "LightSpeed";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransformOrigin = new Point(0.5, 0.5);
            TransformGroup group = new TransformGroup();
            group.Children.Add(new SkewTransform());
            group.Children.Add(new TranslateTransform());
            element.RenderTransform = group;
        }
    }
    public class LightSpeedInRight : LightSpeedAnimationBase
    {
        public override string AnimationKey { get; set; } = "LightSpeedInRight";
    }
    public class LightSpeedInLeft : LightSpeedAnimationBase
    {
        public override string AnimationKey { get; set; } = "LightSpeedInLeft";
    }
    public class LightSpeedOutRight : LightSpeedAnimationBase
    {
        public override string AnimationKey { get; set; } = "LightSpeedOutRight";
    }
    public class LightSpeedOutLeft : LightSpeedAnimationBase
    {
        public override string AnimationKey { get; set; } = "LightSpeedOutLeft";
    }
}
