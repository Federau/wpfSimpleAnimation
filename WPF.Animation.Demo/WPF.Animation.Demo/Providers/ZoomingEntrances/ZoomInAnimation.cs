using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Animation.Demo.Providers.ZoomingEntrances
{
    public class ZoomInAnimation : ZoomEntrancesAnimationBase
    {
        public override string AnimationKey { get; set; } = "ZoomIn";
    }
    public class ZoomInDownAnimation : ZoomInAnimation
    {
        public override string AnimationKey { get; set; } = "ZoomInDown";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0.5, 1);
        }
    }
    public class ZoomInUpAnimation : ZoomInAnimation
    {
        public override string AnimationKey { get; set; } = "ZoomInUp";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0.5, 1);
        }
    }
    public class ZoomInLeftAnimation : ZoomInAnimation
    {
        public override string AnimationKey { get; set; } = "ZoomInLeft";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
    }
    public class ZoomInRightAnimation : ZoomInAnimation
    {
        public override string AnimationKey { get; set; } = "ZoomInRight";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
    }
}
