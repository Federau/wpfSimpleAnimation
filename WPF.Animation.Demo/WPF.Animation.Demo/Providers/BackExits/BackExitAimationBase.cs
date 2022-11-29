using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace WPF.Animation.Demo.Providers.BackExits
{
    public abstract class BackExitAimationBase : XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "BackExit";
        
    }
   
}
