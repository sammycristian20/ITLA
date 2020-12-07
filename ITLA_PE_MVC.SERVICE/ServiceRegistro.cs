using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITLA_PE_MVC.ENTITY;


namespace ITLA_PE_MVC.SERVICE
{
    public class ServiceRegistro
    {

        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServiceRegistro()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        //MODIFICAR ESTOS METODOS CON LOS NUEVOS PROCEDURES
        public UspServicioRegistroBusqueda_Result ServicioRegistroBusqueda(int idFactura)
        {
            return dbContext.UspServicioRegistroBusqueda(idFactura).SingleOrDefault();
        }

        public void ServicioRegistroInserta(int iDfactura, int iDusuario, DateTime fechaEntrega, string comentario)
        {
            dbContext.UspServicioRegistroInserta(iDfactura, iDusuario, fechaEntrega, comentario);

        }

        public List<UspServicioRegistroReporteSolicitado_Result> ServicioRegistroReporteSolicitado()
        {
            return dbContext.UspServicioRegistroReporteSolicitado().ToList();
        }

        public List<UspServicioRegistroReporteRangoFecha_Result> ServicioRegistroReporteRangoFecha(DateTime ini, DateTime fin)
        {
            return dbContext.UspServicioRegistroReporteRangoFecha(ini,fin).ToList();
        }


    }
}
