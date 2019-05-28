using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace BHHC_Standard.Services
{
    public static class ServiceLocator
    {
        public static T Get<T>()
        {
            return GetService<T>("connectionString");
        }
        public static T Get<T>(string connection)
        {
            return GetService<T>(connection);
        }

        private static T GetService<T>(string connection)
        {
            if (typeof(T) == typeof(IBHHCService))
            {
                return (T)ConfigureService(new BHHCService(), connection);
            }

            throw new NotImplementedException(typeof(T) + " has not been set up.");
        }

        private static object ConfigureService(IBaseService serviceImplementation, string connection)
        {
            serviceImplementation.setConnectionString(connection);
            return serviceImplementation;
        }
    }
}