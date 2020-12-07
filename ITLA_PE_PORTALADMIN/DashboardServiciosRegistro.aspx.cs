using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class DashboardServiciosRegistro : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterCondicionAcademica.DataSource = base.ServicesLayer.ServicesDashboard.GetDashboardRegistroCondicionAcademica();
                RepeaterCondicionAcademica.DataBind();
            }
        }
    }
}