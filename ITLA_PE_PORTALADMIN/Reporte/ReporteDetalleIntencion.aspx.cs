using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN.Reporte
{
    public partial class ReporteDetalleIntencion : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDateFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtDateTo.Text = DateTime.Now.ToString("dd/MM/yyyy");

                refreshReport();
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            refreshReport();
        }

        private void refreshReport()
        {
            

            RepeaterDates.DataSource = base.ServicesLayer.ServiceReport.UspReporteIntencion(txtDateFrom.Text.ToNuleableDateFromddMMyyyy(), txtDateTo.Text.ToNuleableDateFromddMMyyyy());
            RepeaterDates.DataBind();
        }
    }
}