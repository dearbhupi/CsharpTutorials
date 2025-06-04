using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCartSimulation.DemoLibrary
{
    internal class PhysicalProductModel
    {
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public void ShipItem(CustomerModel customer)
        {
            Console.WriteLine($"Shipping {ProductName} to {customer.FirstName} {customer.LastName} at {customer.Address}. " +
                              $"Weight: {Weight} kg, Price: ${Price}");
        }
    }
}
