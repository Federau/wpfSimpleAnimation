using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public class ShakeXAnimation : AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "ShakeX";
      
    }
    public class ShakeYAnimation : AttentionSeekerProviderBase
    {
        public override string AnimationKey { get; set; } = "ShakeY";
    }
}
