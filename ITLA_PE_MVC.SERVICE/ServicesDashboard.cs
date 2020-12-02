using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITLA_PE_MVC.ENTITY;
using ITLA_PE_MVC.DATA;


namespace ITLA_PE_MVC.SERVICE
{
    public class ServicesDashboard
    {
        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServicesDashboard()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        public List<UspGetDashboardITLAJVMateria_Result> GetDashboardITLAJVMateria()
        {
            return dbContext.UspGetDashboardITLAJVMateria().ToList();
        }

        public List<UspGetDashboardITLAJVProvincia_Result> GetDashboardITLAJVProvincia()
        {
            return dbContext.UspGetDashboardITLAJVProvincia().ToList();
        }

        public int DashboardGeneralINfo()
        {
            return dbContext.DashboardGeneralINfo().SingleOrDefault().Value;
        }


        public List<UspGetDashboardITLAJVDia_Result> GetDashboardITLAJVDia()
        {
            return dbContext.UspGetDashboardITLAJVDia().ToList();
        }

        public List<UspGetDashboardITLAJVIngresos_Result> GetDashboardITLAJVIngresos()
        {
            return dbContext.UspGetDashboardITLAJVIngresos().ToList();
        }

        public List<UspGetDashboardITLAJVEdad_Result> GetDashboardITLAJVEdad()
        {
            return dbContext.UspGetDashboardITLAJVEdad().ToList();
        }

        public List<UspGetDashboardITLAJVEducacion_Result> GetDashboardITLAJVEducacion()
        {
            return dbContext.UspGetDashboardITLAJVEducacion().ToList();
        }

        public List<UspGetDashboardITLAJVGenero_Result> GetDashboardITLAJVGenero()
        {
            return dbContext.UspGetDashboardITLAJVGenero().ToList();
        }



        //DATOS PARA EL DASHBOARD INTENCION

        public List<UspGetDashboardIntencionProvincia_Result> GetDashboardIntencionProvincia()
        {
            return dbContext.UspGetDashboardIntencionProvincia().ToList();
        }

        public List<UspGetDashboardIntencionEdad_Result> GetDashboardIntencionEdad()
        {
            return dbContext.UspGetDashboardIntencionEdad().ToList();
        }

        public List<UspGetDashboardIntencionArea_Result> GetDashboardIntencionArea()
        {
            return dbContext.UspGetDashboardIntencionArea().ToList();
        }

        public List<UspGetDashboardIntencionDia_Result> GetUspGetDashboardIntencionDias()
        {
            return dbContext.UspGetDashboardIntencionDia().ToList();
        }

        public List<UspGetDashboardIntencionIngresos_Result> GetUspGetDashboardIntencionIngresos()
        {
            return dbContext.UspGetDashboardIntencionIngresos().ToList();
        }



        public List<UspGetDashboardIntencionINTERNET_Result> UspGetDashboardIntencionINTERNET()
        {
            return dbContext.UspGetDashboardIntencionINTERNET().ToList();
        }

        public List<UspGetDashboardIntencionPC_Result> UspGetDashboardIntencionPC()
        {
            return dbContext.UspGetDashboardIntencionPC().ToList();
        }


        public List<UspGetDashboardIntencionEducacion_Result> UspGetDashboardIntencionEducacion()
        {
            return dbContext.UspGetDashboardIntencionEducacion().ToList();
        }



        //METODOS PARA QUE ALIMENTAN AL DASHBOARD HOME

        public List<UspGetPeriodo_Result> GetUspGetPeriodo(int periodo)
        {
            return dbContext.UspGetPeriodo(periodo).ToList();
        }

        public List<UspReporteInscritosSeleccionXCarreraCuatrimestre_Result> UspReporteInscritosSeleccionXCarreraCuatrimestre(int periodo)
        {
            return dbContext.UspReporteInscritosSeleccionXCarreraCuatrimestre(periodo).ToList();
        }

        public List<UspReporteInscritosSeleccionCuatrimestre_Result> UspReporteInscritosSeleccionCuatrimestre(int periodo)
        {
            return dbContext.UspReporteInscritosSeleccionCuatrimestre(periodo).ToList();
        }

        public List<UspReporteInscritosSeleccionXFecha_Result> UspReporteInscritosSeleccionXFecha(int periodo)
        {
            return dbContext.UspReporteInscritosSeleccionXFecha(periodo).ToList();
        }

        public List<DashboardGeneroPorPeriodo_Result> DashboardGeneroPorPeriodo(int periodo)
        {
            return dbContext.DashboardGeneroPorPeriodo(periodo).ToList();
        }

        public List<DashboardRangoEdadPorPeriodo_Result> DashboardRangoEdadPorPeriodo(int periodo)
        {
            return dbContext.DashboardRangoEdadPorPeriodo(periodo).ToList();
        }


        /////
        ///
        

        public List<UspGetDashboardAdmisionInfo_Result> GetDashboardAdmisionInfo()
        {
            return dbContext.UspGetDashboardAdmisionInfo().ToList();
        }

        public List<UspGetDashboardAdmisionCarrera_Result> UspGetDashboardAdmisionCarrera()
        {
            return dbContext.UspGetDashboardAdmisionCarrera().ToList();
        }

        public List<UspGetDashboardAdmisionProvincia_Result> UspGetDashboardAdmisionProvincia()
        {
            return dbContext.UspGetDashboardAdmisionProvincia().ToList();
        }

        public List<UspGetDashboardAdmisionGenero_Result> GetDashboardAdmisionGenero()
        {
            return dbContext.UspGetDashboardAdmisionGenero().ToList();
        }

        public List<UspGetDashboardAdmisionFecha_Result> UspGetDashboardAdmisionFecha()
        {
            return dbContext.UspGetDashboardAdmisionFecha().ToList();
        }

        public List<UspGetDashboardAdmisionEdad_Result> UspGetDashboardAdmisionEdad()
        {
            return dbContext.UspGetDashboardAdmisionEdad().ToList();
        }

        public List<UspGetDashboardAdmisionTanda_Result> UspGetDashboardAdmisionTanda()
        {
            return dbContext.UspGetDashboardAdmisionTanda().ToList();
        }

        public List<UspGetDashboardAdmisionCosteo_Result> GetDashboardAdmisionCosteo()
        {
            return dbContext.UspGetDashboardAdmisionCosteo().ToList();
        }

        public List<UspGetDashboardAdmisionPeriodoIngreso_Result> GetDashboardAdmisionPeriodoIngreso()
        {
            return dbContext.UspGetDashboardAdmisionPeriodoIngreso().ToList();
        }

        public List<UspGetDashboardAdmisionIngresos_Result> GetDashboardAdmisionIngresos()
        {
            return dbContext.UspGetDashboardAdmisionIngresos().ToList();
        }

        public List<UspGetDashboardAdmisionTipoSolicitud_Result> GetDashboardAdmisionTipoSolicitud()
        {
            return dbContext.UspGetDashboardAdmisionTipoSolicitud().ToList();
        }

        public List<UspGetDashboardAdmisionAgendadosPorVenir_Result> GetDashboardAdmisionAgendadosPorVenir()
        {
            return dbContext.UspGetDashboardAdmisionAgendadosPorVenir().ToList();
        }

        ///////
    }
}
