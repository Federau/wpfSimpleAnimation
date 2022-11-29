using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Animation.Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<AnimationInfo> Datas { get; }
        public MainWindow()
        {
            InitializeComponent();
            Datas = new ObservableCollection<AnimationInfo>();
            AddAnimationInfo();
            DataContext = this;

        }

        private void OnExecuteBeginAnimation(AnimationInfo info)
        {
            info.AnimationProvider.ApplyAnimation(showText, info.AnimationKey);
        }
        private void AddAnimationInfo()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface(nameof(IAnimationProvider)) != null && !type.IsAbstract)
                {
                    var provider = Activator.CreateInstance(type) as IAnimationProvider;
                    Datas.Add(new AnimationInfo
                    {
                        AnimationKey = provider.AnimationKey,
                        AnimationProvider = provider,
                        GroupName = provider.GroupName
                    });
                }
            }
        }

        private void ListBoxItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OnExecuteBeginAnimation((sender as ListBoxItem).Content as AnimationInfo);
        }
    }
    public class AnimationInfo
    {
        public string GroupName { get; set; }
        public string AnimationKey { get; set; }
        public IAnimationProvider AnimationProvider { get; set; }

    }

}
