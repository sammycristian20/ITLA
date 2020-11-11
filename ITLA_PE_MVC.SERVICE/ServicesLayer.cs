using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLA_PE_MVC.SERVICE
{
    public class ServicesLayer
    {
        ServicioJuventudADM servicioJuventudADM = null;
        ServicesDashboard servicesDashboard = null;
        ServiceReport serviceReport = null;
        public ServicioJuventudADM ServicioJuventudADM
        {
            get
            {
                if (servicioJuventudADM == null)
                    servicioJuventudADM = new ServicioJuventudADM();

                return servicioJuventudADM;
            }
        }

        public ServicesDashboard ServicesDashboard
        {
            get
            {
                if (servicesDashboard == null)
                    servicesDashboard = new ServicesDashboard();

                return servicesDashboard;
            }
        }

        public ServiceReport ServiceReport
        {
            get
            {
                if (serviceReport == null)
                    serviceReport = new ServiceReport();

                return serviceReport;
            }
        }

    }
}
