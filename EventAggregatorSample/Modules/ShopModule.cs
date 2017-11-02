using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAggregatorSample.ViewModels;
using EventAggregatorSample.Views.Regions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace EventAggregatorSample.Modules
{
    public class ShopModule : IModule
    {
        public IUnityContainer Container { get; private set; }
        public IRegionManager RegionManager { get; private set; }

        public ShopModule(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }
        
        public void Initialize()
        {
            var viewModel = Container.Resolve<ShopViewModel>();
            var view = Container.Resolve<ShopOrderView>();
            view.DataContext = viewModel;
            RegionManager.Regions["ShopRegion"].Add(view);
        }
    }
}
