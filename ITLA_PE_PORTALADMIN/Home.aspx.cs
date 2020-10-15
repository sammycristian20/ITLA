using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class Home :BasePage
    {
        int periodo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                ddlPeriodo.DataSource = base.ServicesLayer.ServicesDashboard.GetUspGetPeriodo();
                ddlPeriodo.DataTextField = "Periodo";
                ddlPeriodo.DataValueField = "IDPeriodo";
                ddlPeriodo.DataBind();

            }
        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ITLA_PE_MVC.SERVICE.ServicesDashboard servicesDashboard = new ITLA_PE_MVC.SERVICE.ServicesDashboard();

            periodo = int.Parse(ddlPeriodo.SelectedValue);

            RepeaterCarreras.DataSource = servicesDashboard.UspReporteInscritosSeleccionXCarreraCuatrimestre(periodo);
            RepeaterCarreras.DataBind();


            

            RepeaterInscritos.DataSource = servicesDashboard.UspReporteInscritosSeleccionCuatrimestre(periodo);
            RepeaterInscritos.DataBind();

            RepeaterFechas.DataSource = servicesDashboard.UspReporteInscritosSeleccionXFecha(periodo);
            RepeaterFechas.DataBind();


            var total = servicesDashboard.UspReporteInscritosSeleccionXCarreraCuatrimestre(periodo);

            literalNuevoIngreso.Text = total.Sum(a => a.NuevoIngreso).ToString();
            literalReinscritos.Text = total.Sum(a => a.Viejos).ToString();
            literalTotalInscritos.Text = total.Sum(set => set.Total).ToString();


            double totalInscritos = (int)total.Sum(set => set.Total);
            double reinscritos = (int)total.Sum(a => a.Viejos);
            int nuevos = (int)total.Sum(a => a.NuevoIngreso);



            double porcientoReinscritos = Math.Round(reinscritos * 100 / totalInscritos);
            double porcientoNuevos = Math.Round(nuevos * 100 / totalInscritos);

            literalPorcientoReinscritos.Text = porcientoReinscritos.ToString();
            literalNuevos.Text = porcientoNuevos.ToString();
        }
    }
}