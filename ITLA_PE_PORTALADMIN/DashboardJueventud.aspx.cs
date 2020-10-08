using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class DashboardJueventud : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ITLA_PE_MVC.SERVICE.ServicesDashboard servicesDashboard = new ITLA_PE_MVC.SERVICE.ServicesDashboard();

                RepeaterMaterias.DataSource = servicesDashboard.GetDashboardITLAJVMateria();
                RepeaterMaterias.DataBind();


                var porProvincias = servicesDashboard.GetDashboardITLAJVProvincia();

                RepeaterProvincias.DataSource = porProvincias;
                RepeaterProvincias.DataBind();

                literalTotalSolicitudes.Text = porProvincias.Sum(set => set.Cantidad).ToString();
                int? total = porProvincias.Sum(set => set.Cantidad);

                int? canidadGS = porProvincias.Where(set => set.Provincia == "SANTO DOMINGO" || set.Provincia == "DISTRITO NACIONAL").Sum(set => set.Cantidad);
                int? cantidadNOGS = porProvincias.Where(set => set.Provincia != "SANTO DOMINGO" && set.Provincia != "DISTRITO NACIONAL").Sum(set => set.Cantidad);
                literalTotalSolicitudesGS.Text = canidadGS.ToString() + " (" + (decimal.Parse(canidadGS.ToString()) / decimal.Parse(total.ToString())).ToString("p") +  ")" ;
                literalNOGS.Text = cantidadNOGS.ToString() + " (" + (decimal.Parse(cantidadNOGS.ToString()) / decimal.Parse(total.ToString())).ToString("p") + ")";

                literalPreValidados.Text = servicesDashboard.DashboardGeneralINfo().ToString();

                RepeaterDia.DataSource = servicesDashboard.GetDashboardITLAJVDia();
                RepeaterDia.DataBind();

                RepeaterEdad.DataSource = servicesDashboard.GetDashboardITLAJVEdad();
                RepeaterEdad.DataBind();

                RepeaterIngresos.DataSource = servicesDashboard.GetDashboardITLAJVIngresos();
                RepeaterIngresos.DataBind();





            }
        }
    }
}