using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class ReporteCondicionAcademica : BasePage
    {
        int periodo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
                int recinto = 5;
                string n_corto = "C";
                int tipoPeriodo = 1;
                int naturaleza = 1;


                DDLPeriodo.DataSource = base.ServicesLayer.ServicesDashboard.GetUspGetPeriodo(recinto, n_corto, tipoPeriodo, naturaleza);
                DDLPeriodo.DataTextField = "Periodo";
                DDLPeriodo.DataValueField = "IDPeriodo";
                DDLPeriodo.DataBind();
                Carga();
            }
        }

        protected void DDLPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carga();
        }

        protected void Carga()
        {
            periodo = int.Parse(DDLPeriodo.SelectedValue);
            RepeaterCondicionAcademica.DataSource = ServicesLayer.ServiceRegistro.ServicioRegistroReporteCondicionAcademica(periodo);
            RepeaterCondicionAcademica.DataBind();
        }
    }
}