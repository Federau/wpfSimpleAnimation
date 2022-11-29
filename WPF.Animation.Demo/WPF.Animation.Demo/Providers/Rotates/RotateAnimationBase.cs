using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.Rotates
{
    public abstract class RotateAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "Rotates";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransform = new RotateTransform();
           
        }
    }
    public class RotateOutAnimation : RotateAnimationBase
    {
        public override string AnimationKey { get; set; } = "RotateOut";
    }
    public class RotateOutDownLeftAnimation : RotateAnimationBase
    {
        public override string AnimationKey { get; set; } = "RotateOutDownLeft";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0,1);
        }
    }
    public class RotateOutDownRightAnimation : RotateAnimationBase
    {
        public override string AnimationKey { get; set; } = "RotateOutDownRight";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(1, 1);
        }
    }
    public class RotateOutUpLeftAnimation : RotateAnimationBase
    {
        public override string AnimationKey { get; set; } = "RotateOutUpLeft";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0, 1);
        }
    }
    public class RotateOutUpRightAnimation : RotateAnimationBase
    {
        public override string AnimationKey { get; set; } = "RotateOutUpRight";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(1, 1);
        }
    }
}
