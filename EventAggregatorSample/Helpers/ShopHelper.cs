using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAggregatorSample.Models;

namespace EventAggregatorSample.Helpers
{
    public class ShopHelper
    {
        public static IEnumerable<Book> GenerateBooks()
        {
            yield return new Book { Id = 1, Author = "Jon Skeet", Title = "C# in Depth", Price = 22.5, SN = "ISBN: 9781617291340", Year = new DateTime(2013, 9, 10) };
            yield return new Book { Id = 2, Author = "Martin Fowler", Title = "Refactoring: Improving the Design of Existing Code", Price = 41.52, SN = "ISBN-10: 0201485672", Year = new DateTime(1999, 7, 8) };
            yield return new Book { Id = 3, Author = "Jeffrey Richter", Title = "CLR via C# (Developer Reference)", Price = 35, SN = "ISBN-10: 0735667454", Year = new DateTime(2012, 12, 4) };
        }

        public static IEnumerable<Customer> GenerateCustomers()
        {
            yield return new Customer { Id = 1, Age = 21, FirstName = "Filip", LastName = "Morris" };
            yield return new Customer { Id = 2, Age = 35, FirstName = "Dunkan", LastName = "Maklaud" };
            yield return new Customer { Id = 3, Age = 34, FirstName = "Nikolas", LastName = "Petrol" };
        }
    }
}
