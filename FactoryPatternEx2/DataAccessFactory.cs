using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQLDataAccess();
                case "mongo":
                case "mongodb":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
