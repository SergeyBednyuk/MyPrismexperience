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
    public class OrderModule : IModule
    {
        public OrderModule(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }
        public void Initialize()
        {
            var viewModel = Container.Resolve<OrderViewModel>();
            var view = Container.Resolve<OrderView>();
            view.DataContext = viewModel;
            RegionManager.Regions["OrderRegion"].Add(view);
        }

        public IUnityContainer Container { get; private set; }
        public IRegionManager RegionManager { get; private set; }
    }
}
