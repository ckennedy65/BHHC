using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BHHC_Standard.DataAccess;

namespace BHHC_Standard.Services
{
    public class BHHCService
    {
        public void AddRationale(string rationale)
        {
            var dataAccess = GetDataAccess();
            dataAccess.AddRationale(rationale);
        }

        public List<string> GetRationales()
        {
            var rationales = new List<string>();
            var dataAccess = GetDataAccess();
            rationales = dataAccess.GetRationales();
            return rationales;
        }

        private BHHCDataAccess GetDataAccess()
        {
            return new BHHCDataAccess();
        }

    }
}