using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
            Console.WriteLine("Accessing the SQL Database...\n");
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from your SQL database");
            return Program.products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving your data from your SQL database");
        }
    }
}
