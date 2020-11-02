using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSplitter.CustomClasses
{
    class Processing
    {
        public static bool ValidateForm(string source, string destination)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                ResponseBoxes.ShowErrorBox("Please select a source document to split.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(destination))
            {
                ResponseBoxes.ShowErrorBox("Please select a folder destination.");
                return false;
            }

            //if(_chkBoxNamesList.Items.Count < 2)
            //{
            //    ResponseBoxes.ShowErrorBox("Atleast 2 file names are required.");
            //    return false;
            //}
            return true;
        }



    }
}
