﻿using System.Windows;
using EventAggregatorSample.Modules;
using EventAggregatorSample.Views;
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
            IModule orderModule = Container.TryResolve<OrderModule>();

            shopModule.Initialize();
            orderModule.Initialize();
        }
    }
}
