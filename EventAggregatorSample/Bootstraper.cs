using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EventAggregatorSample.Modules;
using EventAggregatorSample.Views;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace EventAggregatorSample
{
    public class Bootstraper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Shell shell = Container.TryResolve<Shell>();
            shell.Show();

            return shell;
        }

        protected override void InitializeModules()
        {
            IModule shopModule = Container.TryResolve<ShopModule>();
            shopModule.Initialize();
        }
    }
}
