using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace WPF.Animation.Demo.Providers.AttentionSeeker
{
    public abstract class AttentionSeekerProviderBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "AttentionSeekers";
      
    }
}
