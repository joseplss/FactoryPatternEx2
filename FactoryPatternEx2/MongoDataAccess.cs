using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
            Console.WriteLine("Accessing the Mongo Database...\n");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from your Mongo database");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from your Mongo database");
        }
    }
}
