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

        public ServicioJuventudADM ServicioJuventudADM
        {
            get
            {
                if (servicioJuventudADM == null)
                    servicioJuventudADM = new ServicioJuventudADM();

                return servicioJuventudADM;
            }
        }


    }
}
