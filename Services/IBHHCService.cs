using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHHC_Standard.Services
{
    public interface IBHHCService
    {
        void AddRationale(string rationale);

        List<string> GetRationales();
    }
}
