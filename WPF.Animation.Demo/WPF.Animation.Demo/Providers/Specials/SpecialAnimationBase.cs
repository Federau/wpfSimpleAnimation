using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Animation.Demo.Providers.Specials
{
    public abstract class SpecialAnimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "Special";
    }
}
