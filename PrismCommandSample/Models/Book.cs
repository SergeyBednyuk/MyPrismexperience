using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace PrismCommandSample.Models
{
    public class Book : BindableBase
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(() => Id);
            }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged(() => Author);
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(() => Title);
            }
        }

        private DateTime _year;
        public DateTime Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged(() => Year);
            }
        }

        private string _sn;
        public string SN
        {
            get { return _sn; }
            set
            {
                _sn = value;
                OnPropertyChanged(() => SN);
            }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(() => Price);
            }
        }
    }
}
