using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.ZoomingEntrances
{
    public abstract class ZoomEntrancesAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "ZoomEntrances";
        public override void PreProcess(UIElement element)
        {
            base.PreProcess(element);
            TransformGroup group = new TransformGroup();
            group.Children.Add(new TranslateTransform());
            group.Children.Add(new ScaleTransform());
            element.RenderTransform = group;
        }
    }
}
