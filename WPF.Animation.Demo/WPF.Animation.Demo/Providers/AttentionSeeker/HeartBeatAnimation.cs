using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public class HeartBeatAnimation:AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "HeartBeat";
       
        public override void PreProcess(UIElement element)
        {
            element.RenderTransformOrigin = new Point(0.5,0.5);
            element.RenderTransform = new ScaleTransform();
        }
    }
}
