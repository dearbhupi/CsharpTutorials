using ShippingCartSimulation.DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel item in cart)
            {
                item.ShipItem(customer);
            }
            Console.WriteLine("All items have been shipped.");
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St, Anytown, USA"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            return new List<PhysicalProductModel>
            {
                new PhysicalProductModel
                {
                    ProductName = "Laptop",
                    Weight = 2.5,
                    Price = 999.99
                },
                new PhysicalProductModel
                {
                    ProductName = "Smartphone",
                    Weight = 0.3,
                    Price = 699.99
                },
                new PhysicalProductModel
                {
                    ProductName = "Headphones",
                    Weight = 0.2,
                    Price = 199.99
                }
            };
        }
    }
}