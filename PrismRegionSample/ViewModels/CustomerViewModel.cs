using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismRegionSample.Models;

namespace PrismRegionSample.ViewModels
{
	public class CustomerViewModel
	{
		#region Constructor
		public CustomerViewModel()
		{
			Customers = new ObservableCollection<Customer>(new[]
				{
					new Customer { Age = 21, FirstName = "Filip", LastName = "Morris"},
					new Customer { Age = 35, FirstName = "Dunkan", LastName = "Maklaud"},
					new Customer { Age = 34, FirstName = "Nikolas", LastName = "Petrol"}
				});
		}
		#endregion

		#region Public Properties
		public ObservableCollection<Customer> Customers { get; set; }
		#endregion
	}
}
