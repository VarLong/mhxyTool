using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPF.ViewModels
{
    internal class TaskViewModel:BindableBase
    {
        private readonly IRegionManager regionManager;

        public DelegateCommand<string> OpenTaskCommand { get; set; }
        public DelegateCommand<string> OpenTaskWebViewCommand { get; set; }

        public TaskViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            OpenTaskCommand = new DelegateCommand<string>(OpenTaskContent);
            OpenTaskWebViewCommand = new DelegateCommand<string>(OpenTaskWebContent);
            this.regionManager.RegisterViewWithRegion("TaskContentRegion", typeof(TaskViewContent));
        }

        private void OpenTaskContent(string tab)
        {
            // 在APP.XAML中通过依赖注入创建View, 默认的是
            NavigationParameters navigationParameters = new NavigationParameters();
            regionManager.Regions["TaskContentRegion"].RequestNavigate(tab);
        }

        private void OpenTaskWebContent(string tab)
        {
            // 在APP.XAML中通过依赖注入创建View, 默认的是
            NavigationParameters navigationParameters = new NavigationParameters();
            regionManager.Regions["TaskWebViewContentRegion"].RequestNavigate(tab);
        }
    }
}
