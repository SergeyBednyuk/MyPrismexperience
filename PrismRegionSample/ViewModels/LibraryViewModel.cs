using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismRegionSample.Models;

namespace PrismRegionSample.ViewModels
{
	public class LibraryViewModel
	{
		#region Constructor
		public LibraryViewModel()
		{
			Books = new ObservableCollection<Book>();
			Books.Add(new Book { Author = "Jon Skeet", Title = "C# in Depth", Count = 3, SN = "ISBN: 9781617291340", Year = new DateTime(2013, 9, 10) });
			Books.Add(new Book { Author = "Martin Fowler", Title = "Refactoring: Improving the Design of Existing Code", Count = 2, SN = "ISBN-10: 0201485672", Year = new DateTime(1999, 7, 8) });
			Books.Add(new Book { Author = "Jeffrey Richter", Title = "CLR via C# (Developer Reference)", Count = 5, SN = "ISBN-10: 0735667454", Year = new DateTime(2012, 12, 4) });
		}
		#endregion

		#region Public Properties
		public ObservableCollection<Book> Books { get; set; }

		#endregion
	}
}
