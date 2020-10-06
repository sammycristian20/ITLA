using ITLA_PE_MVC.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLA_PE_MVC.SERVICE
{
    public class ServicioJuventudADM
    {
        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServicioJuventudADM()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        public Solicitud GetNextPrevalidacion()
        {
            lock (this)
            {
                Solicitud result = null;

                int? solicitudID = dbContext.UspGetNextSolicitud().SingleOrDefault();

                if (solicitudID.HasValue)
                {
                    result = dbContext.Solicituds.Find(solicitudID.Value);
                }

                return result;
            }
        }

        public Solicitud SolicitudGet(int id) { return dbContext.Solicituds.Find(id); }
        public void SolicitudUpdate(Solicitud obj) { dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified; dbContext.SaveChanges(); ; }
        public void SolicitudAdd(Solicitud obj) { dbContext.Solicituds.Add(obj); dbContext.SaveChanges(); }
        public List<Solicitud> SolicitudList() { return dbContext.Solicituds.ToList(); }

    }
}
