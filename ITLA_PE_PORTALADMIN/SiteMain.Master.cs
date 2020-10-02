using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class SiteMain : System.Web.UI.MasterPage
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            if (ITLA_PE_MVC.ENTITY.RUNTIME.RunTimeHelper.UserID.HasValue == false)
            {
        
                Response.Redirect(@"\ClearSession.aspx", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LiteralName.Text = ITLA_PE_MVC.ENTITY.RUNTIME.RunTimeHelper.FullName;
            }
        }
    }
}