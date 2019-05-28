using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BHHC_Standard.DataAccess;

namespace BHHC_Standard.Services
{
    public class BHHCService : BaseService, IBHHCService
    {
        public void AddRationale(string rationale)
        {
            //Get DataAccessLocator for BHHCDataAccess.AddRationale to save new data
            DataAccessLocator.Get<IBHHCDataAccess>("connectionString").AddRationale(rationale);
            //var dataAccess = GetDataAccess();
            //dataAccess.AddRationale(rationale);
        }

        public List<string> GetRationales()
        {
            var rationales = new List<string>();
            //Get DataAccessLocator for BHHCDataAccess.GetRationales and return result
            return DataAccessLocator.Get<IBHHCDataAccess>("connectionString").GetRationales();
            //var dataAccess = GetDataAccess();
            //rationales = dataAccess.GetRationales();
            //return rationales;
        }

        //private BHHCDataAccess GetDataAccess()
        //{
        //    return new BHHCDataAccess();
        //}

    }
}