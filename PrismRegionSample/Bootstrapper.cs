using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using PrismRegionSample.Modules;
using PrismRegionSample.Views;
using Microsoft.Practices.Unity;

namespace PrismRegionSample
{
	public class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			Shell shell = Container.Resolve<Shell>();
			shell.Show();

			return shell;
		}

		protected override void InitializeModules()
		{
			IModule moduleBook = Container.Resolve<BookModule>();
			IModule moduleCustomer = Container.Resolve<CustomerModule>();

			moduleBook.Initialize();
			moduleCustomer.Initialize();
		}
	}
}
