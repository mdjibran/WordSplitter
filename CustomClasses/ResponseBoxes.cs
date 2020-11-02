using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSplitter.CustomClasses
{
    class ResponseBoxes
    {
        public static void ShowExceptionBox(Exception ex)
        {
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorBox(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void ShowSuccessBox()
        {
            MessageBox.Show("Process Completed Successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowMessageBox(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
