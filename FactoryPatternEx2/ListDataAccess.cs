using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
            Console.WriteLine("Accessing the List...\n");
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading your data from your list");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from your List");
        }
    }
}
