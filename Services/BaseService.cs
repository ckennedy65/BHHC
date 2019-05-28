using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHHC_Standard.Services
{
    public class BaseService : IBaseService
    {
        public void setConnectionString(string xsConnectionString)
        {
            connectionString = xsConnectionString;
        }
        
        protected string connectionString = "";
    }
}