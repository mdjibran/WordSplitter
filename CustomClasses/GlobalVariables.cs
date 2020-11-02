using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSplitter.CustomClasses
{
    class GlobalVariables
    {
        private static string LogDetails = null;

        public static void SaveLogs(string log)
        {
            LogDetails += log;
        }

        public static string GetLogs()
        {
            return LogDetails;
        }

    }
}
