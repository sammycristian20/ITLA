﻿using System;
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



    }
}
