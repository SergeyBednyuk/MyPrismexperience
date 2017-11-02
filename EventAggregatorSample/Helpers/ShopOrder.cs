using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAggregatorSample.Models;

namespace EventAggregatorSample.Helpers
{
    public class ShopOrder
    {
        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
