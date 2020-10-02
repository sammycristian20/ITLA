using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ITLA_PE_MVC.ENTITY.RUNTIME
{
    public class RunTimeHelper
    {
        public static int? UserID
        {
            get
            {
                int? result = null;

                if (HttpContext.Current.Session["UserID"] != null)
                    result = (int)HttpContext.Current.Session["UserID"];

                return result;
            }
        }

        public static int? UsuarioIDOrbi
        {
            get
            {
                int? result = null;

                if (HttpContext.Current.Session["UsuarioIDOrbi"] != null)
                    result = (int)HttpContext.Current.Session["UsuarioIDOrbi"];

                return result;
            }
        }

        public static string UserTypeCode
        {
            get
            {
                string result = "";

                if (HttpContext.Current.Session["UserTypeCode"] != null)
                    result = HttpContext.Current.Session["UserTypeCode"].ToString();

                return result;
            }
        }

        public static string FullName
        {
            get
            {
                string result = "";

                if (HttpContext.Current.Session["FullName"] != null)
                    result = HttpContext.Current.Session["FullName"].ToString();

                return result;
            }
        }

    }
}
