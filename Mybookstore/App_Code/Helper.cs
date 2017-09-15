using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

namespace Mybookstore.App_Code
{
    public class Helper
    {
        public static string GetCon()
        {
            return ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
        }
    }
}