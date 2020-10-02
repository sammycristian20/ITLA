using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITLA_PE_MVC.ENTITY;
using ITLA_PE_MVC.ENTITY.MODELS;

namespace ITLA_PE_MVC.Models
{
    public class SolicitudViewModel
    {
        public ModelSolicituds Solicitud { get; set; }
        public HttpPostedFileBase PostFile { get; set; }
        public String ProvinciaId { get; set; }
        public string FilePathCedula { get; set; }
        public string FilePathActa { get; set; }
        public string FilePathEstudios { get; set; }
        public HttpPostedFileBase PostFileActa { get; set; }
        public HttpPostedFileBase PostFileEstudios { get; set; }
        public int TieneInternetVal { get; set; }
        public int TieneLaptopPcVal { get; set; }
        public int TieneSubsidioVal { get; set; }
    }
}