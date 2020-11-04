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

        public double cantMasculino { get; set; }
        public double cantFemenino { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ESTA VARIABLE ES PARA CONTROLAR CUAL ES EL CICLO ACTUAL Y TENERLO COMO CICLO TOPE EN EL DROPDOWNLIST
                int periodoActual = 172;

                ddlPeriodo.DataSource = base.ServicesLayer.ServicesDashboard.GetUspGetPeriodo(periodoActual);
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


            var total = servicesDashboard.UspReporteInscritosSeleccionCuatrimestre(periodo);
            RepeaterInscritos.DataSource = total;
            RepeaterInscritos.DataBind();
            



            RepeaterFechas.DataSource = servicesDashboard.UspReporteInscritosSeleccionXFecha(periodo);
            RepeaterFechas.DataBind();

            
            var totalGenero = servicesDashboard.UspReporteInscritosSeleccionXGenero(periodo);
            RepeaterGenero.DataSource = totalGenero;
            RepeaterGenero.DataBind();

            cantMasculino = (int)totalGenero.Max(a=>a.Total);
            cantFemenino = (int)totalGenero.Min(a=>a.Total);

            //string masc = (totalGenero.First().ToString());
           // string fem = (totalGenero.Last().ToString());

          //  cantMasculino = int.Parse(masc);
         //   cantFemenino = int.Parse(fem);

            RepeaterGeneroNuevosViejos.DataSource = servicesDashboard.UspReporteInscritosSeleccionXGeneroNuevosViejos(periodo);
            RepeaterGeneroNuevosViejos.DataBind();

            RepeaterCarreraGenero.DataSource = servicesDashboard.UspReporteInscritosSeleccionXGeneroYCarrera(periodo);
            RepeaterCarreraGenero.DataBind();

            RepeaterProvincia.DataSource = servicesDashboard.UspReporteInscritosSeleccionXProvincia(periodo);
            RepeaterProvincia.DataBind();

            RepeaterPais.DataSource = servicesDashboard.UspReporteInscritosSeleccionXPais(periodo);
            RepeaterPais.DataBind();



            literalNuevoIngreso.Text = total.Sum(a => a.Nuevo_Ingreso).ToString();
            literalReinscritos.Text = total.Sum(a => a.Viejos).ToString();
            literalTotalInscritos.Text = total.Sum(set => set.Total1).ToString();



            double totalInscritos = (int)total.Sum(set => set.Total1);
            CantViejos = (int)total.Sum(a => a.Viejos);
            CantNuevos = (int)total.Sum(a => a.Nuevo_Ingreso);

                                 
            
            double porcientoReinscritos = Math.Round(CantViejos * 100 / totalInscritos);
            double porcientoNuevos = Math.Round(CantNuevos * 100 / totalInscritos);

            literalPorcientoReinscritos.Text = porcientoReinscritos.ToString();
            literalNuevos.Text = porcientoNuevos.ToString();




        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaInicial();

            
        }
    }
}