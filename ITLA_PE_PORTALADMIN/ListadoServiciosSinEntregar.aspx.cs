using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class ListadoServiciosSinEntregar : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.RepeaterDates.DataSource = base.ServicesLayer.ServiceRegistro.ReporteServiciosRegistro();
                this.RepeaterDates.DataBind();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            this.RepeaterDates.DataSource = base.ServicesLayer.ServiceRegistro.ReporteServiciosRegistro();
            this.RepeaterDates.DataBind();
        }
    }
}