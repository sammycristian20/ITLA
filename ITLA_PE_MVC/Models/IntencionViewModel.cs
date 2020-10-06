using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITLA_PE_MVC.ENTITY.MODELS;

namespace ITLA_PE_MVC.Models
{
    public class IntencionViewModel
    {
        public ModelIntencion Intencion { get; set; }
        public String ProvinciaId { get; set; }
        public int TieneInternetVal { get; set; }
        public int TieneLaptopPcVal { get; set; }
        public int TieneSubsidioVal { get; set; }        

    }
}