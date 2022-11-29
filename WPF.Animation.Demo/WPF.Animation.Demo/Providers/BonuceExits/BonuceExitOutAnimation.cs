using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPF.Animation.Demo.Providers.BonuceExit
{
    public class BonuceExitOutAnimation : CodeBehindAnimationProvider
    {
        public override string GroupName => "BonuceExits";
        public override string AnimationKey => "BonuceOut";

        public override void ApplyAnimation(UIElement element, string animationKey)
        {
            element.RenderTransform = new ScaleTransform();
            element.RenderTransformOrigin = new Point(0.5, 0.5);
            Storyboard storyboard = new Storyboard();
            DoubleAnimation enLargeX = new DoubleAnimation();
            enLargeX.From = 0.8;
            enLargeX.To = 1;
            var bounceEase = new BounceEase();
            bounceEase.Bounces = 1;
            enLargeX.EasingFunction = bounceEase;
            enLargeX.Duration = TimeSpan.FromSeconds(0.2);
            Storyboard.SetTargetProperty(enLargeX, new PropertyPath("RenderTransform.ScaleX"));
            Storyboard.SetTarget(enLargeX, element);
            storyboard.Children.Add(enLargeX);
            DoubleAnimation enLargeY = new DoubleAnimation();
            enLargeY.From = 0.8;
            enLargeY.To = 1;
            enLargeY.EasingFunction = bounceEase;
            enLargeY.Duration = TimeSpan.FromSeconds(0.2);
            Storyboard.SetTargetProperty(enLargeY, new PropertyPath("RenderTransform.ScaleY"));
            Storyboard.SetTarget(enLargeY, element);
            storyboard.Children.Add(enLargeY);
            DoubleAnimation xAnimation = new DoubleAnimation();
            xAnimation.BeginTime = TimeSpan.FromSeconds(0.2);
            xAnimation.From = 1;
            xAnimation.To = 0;
            xAnimation.Duration = TimeSpan.FromSeconds(0.5);
            Storyboard.SetTargetProperty(xAnimation, new PropertyPath("RenderTransform.ScaleX"));
            Storyboard.SetTarget(xAnimation, element);
            storyboard.Children.Add(xAnimation);
            DoubleAnimation yAnimation = new DoubleAnimation();
            yAnimation.BeginTime = TimeSpan.FromSeconds(0.2);
            yAnimation.From = 1;
            yAnimation.To = 0;
            yAnimation.Duration = TimeSpan.FromSeconds(0.5);
            Storyboard.SetTargetProperty(yAnimation, new PropertyPath("RenderTransform.ScaleY"));
            Storyboard.SetTarget(yAnimation, element);
            storyboard.Children.Add(yAnimation);
            storyboard.Begin();
        }
    }
}
