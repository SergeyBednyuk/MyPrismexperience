using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAggregatorSample.Helpers;
using EventAggregatorSample.Models;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;

namespace EventAggregatorSample.ViewModels
{
    public class ShopViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;

        public ShopViewModel(IEventAggregator eventAggregator)
        {
            //Generate books
            Books = new ObservableCollection<Book>(ShopHelper.GenerateBooks());
            //Generate customers
            Customers = new ObservableCollection<Customer>(ShopHelper.GenerateCustomers());

            BuyBookCommand = new DelegateCommand(BuyBook, CanBuyBook);

            _eventAggregator = eventAggregator;
        }

        public ObservableCollection<Customer> Customers { get; set; }
        public ObservableCollection<Book> Books { get; set; }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(() => SelectedBook);
                BuyBookCommand.RaiseCanExecuteChanged();
            }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged(() => SelectedCustomer);
                BuyBookCommand.RaiseCanExecuteChanged();
            }
        }

        #region Command
        public DelegateCommand BuyBookCommand { get; set; }

        #endregion

        #region Private Methods
        private bool CanBuyBook()
        {
            return SelectedBook != null && SelectedCustomer != null;
        }

        private void BuyBook()
        {
            var shopOrder = new ShopOrder();
            shopOrder.Book = SelectedBook;
            shopOrder.Customer = SelectedCustomer;
            _eventAggregator.GetEvent<ShopOrderEvent>().Publish(shopOrder);
        }
        #endregion
    }
}
