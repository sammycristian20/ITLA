using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ITLA_PE_MVC;
using ITLA_PE_MVC.Models;
//using ITLA_PE_MVC.Services;
using ITLA_PE_MVC.Utils;
using ITLA_PE_MVC.SERVICE;
using ITLA_PE_MVC.ENTITY;
using System.Web.Routing;
namespace ITLA_PE_MVC.Controllers
{
    public class IntencionController : Controller
    {
        ServicesRequest serv = new ServicesRequest();
        private DropdownsGet ddg = new DropdownsGet();

        // GET: Intencion
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        // GET: Intencion/Create
        public ActionResult Create()
        {

            ViewBag._provinciasItems = ddg.getProvincias();
            var items = ddg.getAssigmentsAviable();
            ViewBag._proyectosEspItems = items;
            ViewBag._proyectosEspItems2 = items;
            ViewBag._generectTypeIdentification = ddg.getIdentificationType();
            ViewBag._generectTypeIngresoFamiliar = ddg.getIngresoFamiliar();
            ViewBag._getAcdemyLevel = ddg.getAcademicLevel();
            ViewBag._getTrueFalse = ddg.getTrueFalse();
            ViewBag._getCarreras = ddg.getCarreras();
            //  ViewBag.ProyectoEspecialMateriaGrupoID = new SelectList(db.ProyectoEspecialMateriaGrupo, "ProyectoEspecialMateriaGrupoID", "ProyectoEspecialMateriaGrupoID");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(IntencionViewModel intencionVM)
        {

            int soliId = 0;
            if (ModelState.IsValid)
            {
                bool validateDuplicate = false;
                string fixCedula = intencionVM.Intencion.IdentificacionCedula.Replace("-", "");
                var consultaCedulas = serv.SolicitudCheckIntencionCedula(fixCedula);
                validateDuplicate = consultaCedulas == null;
                //if (solicitudVM.Solicitud)
                //if (solicitudVM.Solicitud.GenericID_TipoIdentificacion == 10) {
                //  consulCedula = consultaCedulas == null;
                //}


                if (validateDuplicate == true)
                {

                    intencionVM.Intencion.TieneInternet = intencionVM.TieneInternetVal == 0 ? false : true;
                    intencionVM.Intencion.TieneLaptopPc = intencionVM.TieneLaptopPcVal == 0 ? false : true;
                    intencionVM.Intencion.TieneSubsidio = intencionVM.TieneSubsidioVal == 0 ? false : true;
                    intencionVM.Intencion.DireccionidMunicipio = intencionVM.Intencion.Idmunicipio;
                    
                    
                    var soli = serv.IntencionAdd(intencionVM.Intencion);



                    soliId = soli.IntencionID;
                    

                    try
                    {


                        string codigo = serv.CodeIntencionById(soli);

                        string emailBody = System.IO.File.ReadAllText(Server.MapPath(@"/Template/ITLA-Intencion.html")).Replace("@@email", intencionVM.Intencion.Nombres + " " + intencionVM.Intencion.Apellidos);

                        emailBody = emailBody.Replace("@@codigo", codigo);
                        emailBody = emailBody.Replace("@@locationUrl", @"https://www.puntostecnologicos.com/solicitudes/find/" + codigo);

                        //UploadFile(soli.SolicitudID, soli.Email, solicitudVM.PostFileEstudios, 9);
                        bool statusMail = serv.sendEmail(soli, emailBody);


                    }
                    catch
                    {

                    }


                }

                //devuelve true si el envio de corro fue exitoso. 
                //return RedirectToAction("NoSolicitud");
                return RedirectToAction("NumeroSolicitud", new RouteValueDictionary(
                new { controller = "Intencion", action = "NumeroSolicitud", Id = soliId }));

            }
                        

            return View(intencionVM.Intencion);
        }


        public ActionResult NumeroSolicitud(int id)
        {
            var solicitud = serv.CodeIntencionById(id);
            ViewBag.NoSolicitud = solicitud.CodigoIntencion;
            ViewBag.Email = solicitud.Email;
            return View();
        }


        public JsonResult validateCedula(string cedula)
        {
            var message = "";
            var consulCedula = serv.IntencionCheckCedula(cedula.Replace("-", ""));
            if (consulCedula != null)
            {
                message = "Esta cedula ya se encuentra registrada";
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

 

        public JsonResult validateEmail(string email)
        {
            var message = "";
            var consultEmail = serv.IntencionCheckEmail(email);
            if (consultEmail != null)
            {
                message = "Este correo ya se encuentra registrado";
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }


    }
}