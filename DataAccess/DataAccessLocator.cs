using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHHC_Standard.DataAccess
{
    public static class DataAccessLocator
    {
        public static T Get<T>(string connectionString)
        {
            if (typeof(T) == typeof(IBHHCDataAccess))
            {
                return (T) ConfigureDataAccess(new BHHCDataAccess(), connectionString);
            }
            throw new NotImplementedException(typeof(T) + " has not been set up.");
        }
        
        private static object ConfigureDataAccess(IBaseDataAccess accessImplementation, string connectionString)
        {
            accessImplementation.setConnectionString(connectionString);
            return accessImplementation;
        }
    }
}