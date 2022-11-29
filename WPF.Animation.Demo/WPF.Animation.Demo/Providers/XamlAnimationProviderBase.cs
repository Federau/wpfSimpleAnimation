using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPF.Animation.Demo.Providers
{
    public abstract class XamlAnimationProviderBase : IAnimationProvider
    {
        public abstract string GroupName { get; set; }
        public abstract string AnimationKey { get; set; }
        public virtual void PreProcess(UIElement element)
        {
            element.RenderTransformOrigin = new Point(0.5, 0.5);
        }
        public virtual void ApplyAnimation(UIElement element, string animationKey)
        {
            PreProcess(element);
            object obj = Application.Current.Resources[animationKey];
            if (obj == null)
                return;
            ApplyDetail(obj, element);
        }
        protected virtual void ApplyDetail(object resources, UIElement element)
        {
            var sb = (resources as Storyboard).Clone();
            foreach (Timeline item in sb.Children)
            {
                Storyboard.SetTarget(item, element);
            }
            sb.Completed += (o, e) =>
            {
                element.Opacity = 1;
                element.RenderTransform = new ScaleTransform();
            };
            sb.Begin();
        }


    }
}
