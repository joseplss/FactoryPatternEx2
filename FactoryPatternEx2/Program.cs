using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    public class Program
    {
        public static List<Product> products = new List<Product>()
            {
            new Product() {Name = "Pogo stick", Price = 25.00},
            new Product() {Name = "Skateboard", Price = 35.00}
            };
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use (List, SQL, or Mongo)?");
            var response = Console.ReadLine();
            IDataAccess da = DataAccessFactory.GetDataAccessType(response);

            var productsReturned = da.LoadData();
            Console.WriteLine("Here are your items:\n");
            foreach (var items in productsReturned)
            {
                Console.WriteLine($"Product Name: {items.Name}\nPrice: ${items.Price}");
            }

        }
    }
}
