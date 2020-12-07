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

        public double CantNuevos { get; set; }
        public double CantViejos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //Response.Redirect("DashboardJueventud.aspx");
                //ESTA VARIABLE ES PARA CONTROLAR CUAL ES EL CICLO ACTUAL Y TENERLO COMO CICLO TOPE EN EL DROPDOWNLIST
                //int periodoActual = 172;

                int recinto = 5;
                string n_corto = "C";
                int tipoPeriodo = 1;
                int naturaleza = 1;


                ddlPeriodo.DataSource = base.ServicesLayer.ServicesDashboard.GetUspGetPeriodo(recinto,n_corto,tipoPeriodo,naturaleza);
                ddlPeriodo.DataTextField = "Periodo";
                ddlPeriodo.DataValueField = "IDPeriodo";
                ddlPeriodo.DataBind();

                CargaInicial();

            }
        }

        protected void CargaInicial()
        {
            ITLA_PE_MVC.SERVICE.ServicesDashboard servicesDashboard = new ITLA_PE_MVC.SERVICE.ServicesDashboard();

            periodo = int.Parse(ddlPeriodo.SelectedValue);

            RepeaterCarreras.DataSource = servicesDashboard.UspReporteInscritosSeleccionXCarreraCuatrimestre(periodo);
            RepeaterCarreras.DataBind();


            RepeaterInscritos.DataSource = servicesDashboard.UspReporteInscritosSeleccionCuatrimestre(periodo);
            RepeaterInscritos.DataBind();

            RepeaterFechas.DataSource = servicesDashboard.UspReporteInscritosSeleccionXFecha(periodo);
            RepeaterFechas.DataBind();


            RepeaterGenero.DataSource = servicesDashboard.DashboardGeneroPorPeriodo(periodo);
            RepeaterGenero.DataBind();


            RepeaterEdad.DataSource = servicesDashboard.DashboardRangoEdadPorPeriodo(periodo);
            RepeaterEdad.DataBind();


            var total = servicesDashboard.UspReporteInscritosSeleccionCuatrimestre(periodo);

            literalNuevoIngreso.Text = total.Sum(a => a.Nuevo_Ingreso).ToString();
            literalReinscritos.Text = total.Sum(a => a.Viejos).ToString();
            literalTotalInscritos.Text = total.Sum(set => set.Total1).ToString();




            
            double totalInscritos = (int)total.Sum(set => set.Total1);
            double reinscritos = (int)total.Sum(a => a.Viejos);
            int nuevos = (int)total.Sum(a => a.Nuevo_Ingreso);



            CantNuevos = nuevos;
            CantViejos = reinscritos;




            double porcientoReinscritos = Math.Round(reinscritos * 100 / totalInscritos);
            double porcientoNuevos = Math.Round(nuevos * 100 / totalInscritos);

            literalPorcientoReinscritos.Text = porcientoReinscritos.ToString();
            literalNuevos.Text = porcientoNuevos.ToString();
        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaInicial();

            
        }
    }
}