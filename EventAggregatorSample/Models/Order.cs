using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace EventAggregatorSample.Models
{
    public class Order : BindableBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(() => Id);
            }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged(() => Customer);
            }
        }
        public void AddBook(Book newBook)
        {
            if (Books == null)
                Books = new ObservableCollection<Book>();
            Books.Add(newBook);
            Sum = Books.Sum(x => x.Price);
        }

        public ObservableCollection<Book> Books { get; set; }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(() => SelectedBook);
            }
        }

        private double _sum;
        public double Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
                OnPropertyChanged(() => Sum);
            }
        }
    }
}
