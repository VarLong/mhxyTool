using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using PrismWPF.ViewModels;
using PrismWPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WebModule;

namespace PrismWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            // 返回默认呈现的首页
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 返回一些依赖注入
            containerRegistry.RegisterForNavigation<RoleView>();
            containerRegistry.RegisterForNavigation<SkillView>();
            containerRegistry.RegisterForNavigation<TaskView>();
            containerRegistry.RegisterForNavigation<TaskViewContent>();
            containerRegistry.RegisterForNavigation<TaskViewContentTypeA>();
            containerRegistry.RegisterForNavigation<TaskWebViewMin>();
            containerRegistry.RegisterForNavigation<TaskWebViewMinA>();
        }


        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<WebModuleProfile>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
