using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace WPF.Animation.Demo.Providers.BackEntrance
{
    public abstract class BackEntranceAnimationBase:XamlAnimationProviderBase
    {
        public override string GroupName { get; set; } = "BackEntrance";
    }
}
