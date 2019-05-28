using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;


namespace BHHC_Standard.DataAccess
{
    public class BHHCDataAccess : BaseDataAccess, IBHHCDataAccess
    {
        List<string> allRationales;

        public void AddRationale(string new_rationale)
        {
            var rationales = new List<string>();

            var xs = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            var curFile = @"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml";
            //Check to see if a file exists with rationales
            //If file does not exist, add new rationale to list and serialize it as an xml file
            if (!File.Exists(curFile))
            {
                rationales.Add(new_rationale);
                using (FileStream fs = new FileStream(@"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml", FileMode.OpenOrCreate))
                {
                    xs.Serialize(fs, rationales);
                }
                
            }
            //If existing rationales xml file exists, deserialize it, add new ratioale and re-serialize it 
            else
            {
                var existingRationales = new List<string>();
                using (FileStream fs = new FileStream(@"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml", FileMode.OpenOrCreate))
                {
                    existingRationales = xs.Deserialize(fs) as List<string>;
                }
                existingRationales.Add(new_rationale);

                using (FileStream fs = new FileStream(@"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml", FileMode.OpenOrCreate))
                {
                    xs.Serialize(fs, existingRationales);
                }
            }
        }

        public List<string> GetRationales()
        {
            var currentRationales = new List<string>();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            var curFile = @"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml";
            if (File.Exists(curFile))
            {
                using (FileStream fs = new FileStream(@"C:\Personal\Berkshire\BHHC\BHHC Standard\BHHC Standard\XML\rationales.xml", FileMode.OpenOrCreate))
                {
                    currentRationales = xs.Deserialize(fs) as List<string>;
                }
            }
            //In the event of an empty list (file of existing ratioinales doesn't exist) return empty list to UI and display corresponding message to user
            return currentRationales;
        }
    }
}