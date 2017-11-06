using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.UnityExtensions;
using PrismCommandSample.ViewModels;
using PrismCommandSample.Views;

namespace PrismCommandSample
{
    public class Bootstraper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            var viewModel = Container.TryResolve<BookViewModel>();
            Application.Current.MainWindow.DataContext = viewModel;
            Application.Current.MainWindow.Show();
        }

        protected override void InitializeModules()
        {
            
        }
    }
}
