﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITLA_PE_MVC.ENTITY;

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




        public List<UspGetDashboardIntencionProvincia_Result> GetDashboardIntencionProvincia()
        {
            return dbContext.UspGetDashboardIntencionProvincia().ToList();
        }

    }
}
