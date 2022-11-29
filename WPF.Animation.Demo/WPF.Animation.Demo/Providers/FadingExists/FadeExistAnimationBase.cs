using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.FadingExists
{
    public abstract class FadeExistAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "Fading Exits";
        public override void PreProcess(UIElement element)
        {
            element.RenderTransform = new TranslateTransform();
        }
    }
    public class FadeOutAnimation : FadeExistAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeOut";
    }
    public class FadeOutDownAnimation : FadeExistAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeOutDown";
    }
    public class FadeOutLeftAnimation : FadeExistAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeOutLeft";
    }
    public class FadeOutRightAnimation : FadeExistAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeOutRight";
    }
    public class FadeOutUpAnimation : FadeExistAnimationBase
    {
        public override string AnimationKey { get; set; } = "FadeOutUp";
    }
}
