using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ITLA_PE_MVC.Utils
{
    public class Utils
    {
        public string repairString(string fixString)
        {

            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(fixString);
            var nameFixed = Encoding.UTF8.GetString(bytes);
            return nameFixed;
        }
    }
}