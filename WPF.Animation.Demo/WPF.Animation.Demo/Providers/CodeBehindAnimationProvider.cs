using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Animation.Demo.Providers
{
    public abstract class CodeBehindAnimationProvider : IAnimationProvider
    {
        public abstract string GroupName { get; }
        public abstract string AnimationKey { get; }
        public abstract void ApplyAnimation(UIElement element, string animationKey);

        public void PreProcess(UIElement element)
        {

        }
    }
}
