using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace PrismRegionSample.Models
{
	public class Customer : BindableBase 
	{
		private string _firstName;
		public string FirstName
		{
			get { return _firstName; }
			set
			{
				_firstName = value;
				OnPropertyChanged("FirstName");
			}
		}

		private string _lastName;
		public string LastName
		{
			get { return _lastName; }
			set
			{
				_lastName = value;
				OnPropertyChanged("LastName");
			}
		}

		private int _age;
		public int Age
		{
			get { return _age; }
			set
			{
				_age = value;
				OnPropertyChanged("Age");
			}
		}
	}
}
