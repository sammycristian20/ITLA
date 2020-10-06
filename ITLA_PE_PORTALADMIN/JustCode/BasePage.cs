using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITLA_PE_MVC.SERVICE;

namespace ITLA_PE_PORTALADMIN
{
    public class BasePage : INFONETWORK.COMMONS.basePage
    {
        ServicesLayer servicesLayer = null;

        public ServicesLayer ServicesLayer
        {
            get
            {
                if (servicesLayer == null)
                    servicesLayer = new ServicesLayer();

                return servicesLayer;
            }

        }

    }
}