using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHHC_Standard.DataAccess
{
    public class BaseDataAccess : IBaseDataAccess
    {
        protected string connectionString = "";
        public void setConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}