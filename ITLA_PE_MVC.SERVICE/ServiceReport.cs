using ITLA_PE_MVC.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLA_PE_MVC.SERVICE
{

    public class ServiceReport
    {
        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServiceReport()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        public List<UspReporteIntencion_Result> UspReporteIntencion(DateTime? dateFrom, DateTime? dateTo)
        {
            return dbContext.UspReporteIntencion(dateFrom, dateTo).ToList();
     
        
        }

        public List<UspGetAdmisionAgendados_Result> GetAdmisionAgendados(DateTime date)
        {
            return dbContext.UspGetAdmisionAgendados(date).ToList();
        }

    }
}
