using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using PrismCommandSample.Models;

namespace PrismCommandSample.ViewModels
{
    public class BookViewModel : BindableBase
    {
        #region Constructors
        public BookViewModel()
        {
            Books = new ObservableCollection<Book>(GenerateBooks());
        }
        #endregion

        #region Static Methods
        public static IEnumerable<Book> GenerateBooks()
        {
            yield return new Book { Id = 1, Author = "Jon Skeet", Title = "C# in Depth", Price = 22.5, SN = "ISBN: 9781617291340", Year = new DateTime(2013, 9, 10) };
            yield return new Book { Id = 2, Author = "Martin Fowler", Title = "Refactoring: Improving the Design of Existing Code", Price = 41.52, SN = "ISBN-10: 0201485672", Year = new DateTime(1999, 7, 8) };
            yield return new Book { Id = 3, Author = "Jeffrey Richter", Title = "CLR via C# (Developer Reference)", Price = 35, SN = "ISBN-10: 0735667454", Year = new DateTime(2012, 12, 4) };
        }
        #endregion

        #region Public Properties
        public ObservableCollection<Book> Books { get; set; }

        private Book _currentBook;
        public Book CurrentBook
        {
            get { return _currentBook; }
            set
            {
                _currentBook = value;
                OnPropertyChanged(() => CurrentBook);
                RemoveBookCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Commands

        private DelegateCommand _removeBookCommand;
        public DelegateCommand RemoveBookCommand
        {
            get { return _removeBookCommand ?? (_removeBookCommand = new DelegateCommand(RemoveBook, CanRemoveBook)); }
        }

        private bool CanRemoveBook()
        {
            return CurrentBook != null;
        }

        private void RemoveBook()
        {
            Books.Remove(CurrentBook);
        }

        #endregion
    }
}
