using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class ReporteServiciosEntregados : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime inicio = DateTime.Parse("12-02-2020");
                DateTime fin = DateTime.Parse("12-30-2020");

                RepeaterEntregados.DataSource = ServicesLayer.ServiceRegistro.ServicioRegistroReporteRangoFecha(inicio,fin);
                RepeaterEntregados.DataBind();
            }
        }
    }
}