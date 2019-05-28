using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHHC_Standard.DataAccess
{
    public interface IBaseDataAccess
    {
        void setConnectionString(string connectionString);
    }
}
