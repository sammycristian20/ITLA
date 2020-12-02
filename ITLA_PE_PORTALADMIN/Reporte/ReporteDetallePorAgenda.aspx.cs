using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN.Reporte
{
    public partial class ReporteDetallePorAgenda : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DateTime date = DateTime.ParseExact(Request.QueryString["fecha"], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                this.LiteralTable.Text = base.ServicesLayer.ServiceReport.GetAdmisionAgendados(date).ToHtmlTable().Replace("id='basicTable'", "id='basicTable' class='table table-hover dataTable table-striped width-full'");
            }

        }
    }
}