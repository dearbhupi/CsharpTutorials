using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCartSimulation.DemoLibrary
{
    internal class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Address}";
        }
    }
}
