using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Animation.Demo.Providers.BackEntrance
{
    public class BackInLeftAnimation : BackInDownAnimation
    {
        public override string AnimationKey { get; set; } = "BackInLeft";
    }
    public class BackInRightAnimation : BackInDownAnimation
    {
        public override string AnimationKey { get; set; } = "BackInRight";
    }
    public class BackInUpAnimation : BackInDownAnimation
    {
        public override string AnimationKey { get; set; } = "BackInUp";
    }
}
