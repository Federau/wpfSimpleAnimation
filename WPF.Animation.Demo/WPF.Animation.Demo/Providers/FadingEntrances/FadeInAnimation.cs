using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.FadingEntrances
{
    public class FadeInAnimation : FadingEntranceAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeIn";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransform = new TranslateTransform();
        }
    }
    public class FadeInDownAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInDown";
    }
    public class FadeInLeftAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInLeft";
    }
    public class FadeInRightAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInRight";
    }
    public class FadeInUpAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInUp";
    }
    public class FadeInTopLeftAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInTopLeft";
    }
    public class FadeInTopRightAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInTopRight";
    }
    public class FadeInBottomRightAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInBottomRight";
    }
    public class FadeInBottomLeftAnimation : FadeInAnimation
    {
        public override string AnimationKey { get; set; } = "FadeInBottomLeft";
    }
}
