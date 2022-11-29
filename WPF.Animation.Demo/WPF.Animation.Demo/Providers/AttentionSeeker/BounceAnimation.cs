using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public class BounceAnimation : AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; }= "Bounce";
    }
    public class FlahAnimation : AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "Flash";
    }
}
