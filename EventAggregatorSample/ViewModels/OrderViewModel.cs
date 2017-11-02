using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAggregatorSample.Helpers;
using EventAggregatorSample.Models;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;

namespace EventAggregatorSample.ViewModels
{
    public class OrderViewModel
    {
        private IEventAggregator _eventAggregator;
        private SubscriptionToken subscriptionToken;

        public OrderViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Orders = new ObservableCollection<Order>();
            ShopOrderEvent fundAddedEvent = eventAggregator.GetEvent<ShopOrderEvent>();
            subscriptionToken = fundAddedEvent.Subscribe(AddNewOrderEventHandler, ThreadOption.UIThread, false, (shopOrder) => true);
        }

        public void AddNewOrderEventHandler(ShopOrder shopOrder)
        {
            var order = Orders.FirstOrDefault(x => x.Customer.Id == shopOrder.Customer.Id);
            if (order != null)
            {
                order.AddBook(shopOrder.Book);
            }
            else
            {
                var newOrder = new Order
                {
                    Customer = shopOrder.Customer
                };
                newOrder.AddBook(shopOrder.Book);

                Orders.Add(newOrder);
            }
        }

        public ObservableCollection<Order> Orders { get; set; }
    }
}
