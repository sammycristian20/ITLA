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
                //DateTime inicio = DateTime.Parse("12-01-2020");
                //DateTime fin = DateTime.Parse("12-30-2020");

                FechaDesde.Text = "01/12/2020"; //Poner que tome el 1er del mes actual
                FechaHasta.Text = "30/12/2020"; //Poner que tome el ultimo del mes actual


                UpdateRepetaer();


            }
        }

        private void UpdateRepetaer()
        {
            RepeaterEntregados.DataSource = ServicesLayer.ServiceRegistro.ServicioRegistroReporteRangoFecha(FechaDesde.Text.ToNuleableDateFromddMMyyyy().Value, FechaHasta.Text.ToNuleableDateFromddMMyyyy().Value);
            RepeaterEntregados.DataBind();
        }

        protected void btmBuscar_Click(object sender, EventArgs e)
        {
            UpdateRepetaer();
        }
    }
}