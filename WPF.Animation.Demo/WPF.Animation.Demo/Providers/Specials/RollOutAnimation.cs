using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Animation.Demo.Providers.Specials
{
    public class RollOutAnimation : RollInAnimation
    {
        public override string AnimationKey { get; set; } = "RollOut";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }

    }
}
