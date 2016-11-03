using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace QAWorks.Specs.Utility
{
    class Util
    {

        public static String getlocation(String appconfiKey)
        {
           var folder = ConfigurationManager.AppSettings[appconfiKey];
           return folder;
        }
    }
}
