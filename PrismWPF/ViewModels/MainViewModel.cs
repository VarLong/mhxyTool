using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PrismWPF.ViewModels
{
    internal class MainViewModel: BindableBase
    {
        private readonly IRegionManager regionManager;

        public DelegateCommand<string> OpenCommand { get; set; }

        public MainViewModel(IRegionManager regionManager)
        {
            OpenCommand = new DelegateCommand<string>(Open);
            this.regionManager = regionManager;
        }


        private void Open(string tab)
        {
            // 在APP.XAML中通过依赖注入创建View, 默认的是
            regionManager.Regions["ContentRegion"].RequestNavigate(tab);
        }

    }
}
