using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class DashboardServiciosRegistro : BasePage
    {
        public int C22020Normal { get; set; }
        public int C22020Separado { get; set; }
        public int C22020Prueba { get; set; }

        public int C12020Normal { get; set; }
        public int C12020Separado { get; set; }
        public int C12020Prueba { get; set; }

        public int C32019Normal { get; set; }
        public int C32019Separado { get; set; }
        public int C32019Prueba { get; set; }

        public int Certificacion { get; set; }
        public int Record { get; set; }

        public string NombreUsuario { get; set; }
        public int Cantidad { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var C22020 = base.ServicesLayer.ServicesDashboard.GetDashboardRegistroCondicionAcademica(169);

                RepeaterC22020.DataSource = C22020;
                RepeaterC22020.DataBind();

                C22020Normal = (int)C22020.Where(a=>a.IDcondicion_academica==4).Sum(a=>a.Cantidad);
                C22020Separado = (int)C22020.Where(a => a.IDcondicion_academica==5).Sum(a=>a.Cantidad);
                C22020Prueba = (int)C22020.Where(a => a.IDcondicion_academica == 6).Sum(a=>a.Cantidad);


                var C12020 = base.ServicesLayer.ServicesDashboard.GetDashboardRegistroCondicionAcademica(168);
                RepeaterC12020.DataSource = C12020;
                RepeaterC12020.DataBind();
                C12020Normal = (int)C12020.Where(a => a.IDcondicion_academica == 4).Sum(a => a.Cantidad);
                C12020Separado = (int)C12020.Where(a => a.IDcondicion_academica == 5).Sum(a => a.Cantidad);
                C12020Prueba = (int)C12020.Where(a => a.IDcondicion_academica == 6).Sum(a => a.Cantidad);


                var C32019 = base.ServicesLayer.ServicesDashboard.GetDashboardRegistroCondicionAcademica(157);
                RepeaterC32019.DataSource = C32019;
                RepeaterC32019.DataBind();
                C32019Normal = (int)C32019.Where(a => a.IDcondicion_academica == 4).Sum(a => a.Cantidad);
                C32019Separado = (int)C32019.Where(a => a.IDcondicion_academica == 5).Sum(a => a.Cantidad);
                C32019Prueba = (int)C32019.Where(a => a.IDcondicion_academica == 6).Sum(a => a.Cantidad);


                RepeaterEntregadosFecha.DataSource = ServicesLayer.ServicesDashboard.DashboardRegistroServicioEntregadoFecha();
                RepeaterEntregadosFecha.DataBind();

                var usuario = ServicesLayer.ServicesDashboard.DashboardRegistroServicioEntregadoUsuario();
                RepeaterEntregadosUsuario.DataSource = usuario;
                RepeaterEntregadosUsuario.DataBind();

             //   NombreUsuario = usuario.()


                var tipo  = ServicesLayer.ServicesDashboard.DashboardRegistroServicioEntregadoTipoServicio();
                RepeaterEntregadosTipo.DataSource = tipo;
                RepeaterEntregadosTipo.DataBind();

                Certificacion = (int)tipo.Where(z => z.IDservicio == 8).Sum(z=>z.Cantidad);
                Record = (int)tipo.Where(z => z.IDservicio == 9).Sum(z => z.Cantidad);



            }
        }
    }
}