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

        public List<UspReporteServiciosRegistro_Result> ReporteServiciosRegistro()
        {
            return dbContext.UspReporteServiciosRegistro().ToList();
        }

        public UspBuscaServicioRegistro_Result BuscaServicioRegistro(int idFactura)
        {
            return dbContext.UspBuscaServicioRegistro(idFactura).SingleOrDefault();
        }

        public void PostServicioEntrega(int iDfactura, int iDusuario, DateTime fechaEntrega)
        {
            dbContext.UspPostServicioEntrega(iDfactura, iDusuario, fechaEntrega);

        }



    }
}
