﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class DashboardAdmision : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ITLA_PE_MVC.SERVICE.ServicesDashboard servicesDashboard = new ITLA_PE_MVC.SERVICE.ServicesDashboard();

                RepeaterMaterias.DataSource = servicesDashboard.UspGetDashboardAdmisionCarrera();
                RepeaterMaterias.DataBind();


                RepeaterDia.DataSource = servicesDashboard.UspGetDashboardAdmisionFecha();
                RepeaterDia.DataBind();

                RepeaterProvincias.DataSource = servicesDashboard.UspGetDashboardAdmisionProvincia();
                RepeaterProvincias.DataBind();

                RepeaterIngresos.DataSource = servicesDashboard.GetDashboardAdmisionIngresos();
                RepeaterIngresos.DataBind();

                RepeaterEdad.DataSource = servicesDashboard.UspGetDashboardAdmisionEdad();
                RepeaterEdad.DataBind();

                RepeaterGenero.DataSource = servicesDashboard.GetDashboardAdmisionGenero();
                RepeaterGenero.DataBind();

                RepeaterTanda.DataSource = servicesDashboard.UspGetDashboardAdmisionTanda();
                RepeaterTanda.DataBind();

                RepeaterPeriodo.DataSource = servicesDashboard.GetDashboardAdmisionCosteo();
                RepeaterPeriodo.DataBind();

                RepeaterEducacion.DataSource = servicesDashboard.GetDashboardAdmisionTipoSolicitud();
                RepeaterEducacion.DataBind();


                var info = servicesDashboard.GetDashboardAdmisionInfo().SingleOrDefault();

                literalTotalSolicitudes.Text = info.Cantidad.ToString();
                
                literalPreValidados.Text = info.Meta.ToString();

                decimal porcentante = (decimal.Parse(info.Cantidad.ToString()) / decimal.Parse(info.Meta.ToString()));
                
                literalTotalSolicitudesGS.Text = porcentante.ToString("p");


                //UspGetDashboardAdmisionGenero


                //var porProvincias = servicesDashboard.GetDashboardITLAJVProvincia();

                //RepeaterProvincias.DataSource = porProvincias;
                //RepeaterProvincias.DataBind();

                //literalTotalSolicitudes.Text = porProvincias.Sum(set => set.Cantidad).ToString();
                //int? total = porProvincias.Sum(set => set.Cantidad);

                //int? canidadGS = porProvincias.Where(set => set.Provincia == "SANTO DOMINGO" || set.Provincia == "DISTRITO NACIONAL").Sum(set => set.Cantidad);
                //int? cantidadNOGS = porProvincias.Where(set => set.Provincia != "SANTO DOMINGO" && set.Provincia != "DISTRITO NACIONAL").Sum(set => set.Cantidad);
                //literalTotalSolicitudesGS.Text = canidadGS.ToString() + " (" + (decimal.Parse(canidadGS.ToString()) / decimal.Parse(total.ToString())).ToString("p") + ")";
                //literalNOGS.Text = cantidadNOGS.ToString() + " (" + (decimal.Parse(cantidadNOGS.ToString()) / decimal.Parse(total.ToString())).ToString("p") + ")";

                //literalPreValidados.Text = servicesDashboard.DashboardGeneralINfo().ToString();

                //RepeaterDia.DataSource = servicesDashboard.GetDashboardITLAJVDia();
                //RepeaterDia.DataBind();

                //RepeaterGenero.DataSource = servicesDashboard.GetDashboardITLAJVGenero();
                //RepeaterGenero.DataBind();

                //RepeaterEducacion.DataSource = servicesDashboard.GetDashboardITLAJVEducacion();
                //RepeaterEducacion.DataBind();

                //RepeaterEdad.DataSource = servicesDashboard.GetDashboardITLAJVEdad();
                //RepeaterEdad.DataBind();

                //RepeaterIngresos.DataSource = servicesDashboard.GetDashboardITLAJVIngresos();
                //RepeaterIngresos.DataBind();





            }
        }
    }
}