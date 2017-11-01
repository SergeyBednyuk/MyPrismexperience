using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using PrismRegionSample.ViewModels;
using PrismRegionSample.Views.Regions;

namespace PrismRegionSample.Modules
{
	public class BookModule : IModule
	{
		public BookModule(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }
        public void Initialize()
        {
	        var bookViewModel = Container.Resolve<LibraryViewModel>();
			var view = Container.Resolve<BookView>();
	        view.DataContext = bookViewModel;
			RegionManager.Regions["BookRegion"].Add(view);
        }

        public IUnityContainer Container { get; private set; }
        public IRegionManager RegionManager { get; private set; }
	}
}
