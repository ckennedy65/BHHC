using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BHHC_Standard.Services;

namespace BHHC_Standard
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If page has already loaded, do not display data a second time
            if (IsPostBack) return;

            var existingRationales = GetExistingRationales();
            if(existingRationales.Count > 0)
                DisplayRatioinales(existingRationales);
        }

        private void DisplayRatioinales(List<string> existingRationales)
        {
            if (existingRationales.Count > 0)
            {
                //Add list of strings to GridView control
                dgRationales.DataSource = existingRationales;
                dgRationales.DataBind();
                return;
            }
            //Show Error Message if No File Found for rationales
            MessageBox.Show("NO DATA FOUND", "There are no existing ratioales to display", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            var existingRationales = GetExistingRationales();
            DisplayRatioinales(existingRationales);
        }

        private List<string> GetExistingRationales()
        {
            return ServiceLocator.Get<IBHHCService>().GetRationales();
            //var service = new BHHCService();
            //return service.GetRationales();
        }
        
        [WebMethod(EnableSession = true)]
        public static void AddRationale(string rationale)
        {
            ServiceLocator.Get<IBHHCService>().AddRationale(rationale);
            //var service = new BHHCService();
            //service.AddRationale(rationale);
        }
    }
}