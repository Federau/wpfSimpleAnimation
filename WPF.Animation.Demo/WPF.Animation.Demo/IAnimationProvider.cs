using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Animation.Demo
{
    public interface IAnimationProvider
    {
        string GroupName { get; }
        string AnimationKey { get; }
        void PreProcess(UIElement element);
        void ApplyAnimation(UIElement element, string animationKey);
    }
}
