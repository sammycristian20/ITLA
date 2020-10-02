﻿using System;
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
    public class SolicitudesController : Controller
    {
        //private ORBIPEEntities db = new ORBIPEEntities();
        ServicesRequest serv = new ServicesRequest();
        private DropdownsGet ddg = new DropdownsGet();

        //// GET: Solicitudes
        //public ActionResult Index()
        //{

        //    //var solicitud = db.Solicitud.Include(s => s.ProyectoEspecialMateriaGrupo);
        //    return View(serv.SolicitudList());
        //}
        public ActionResult NumeroSolicitud(int id) {
            var solicitud = serv.CodeSolicitudById(id);
            ViewBag.NoSolicitud = solicitud.CodigoSolicitud;
            ViewBag.Email = solicitud.Email;
            return View();
        }

        public JsonResult GetMuniciposList(int ProvinciaId)
        {
            var municipies = ddg.getMuncicipies(ProvinciaId);
            return Json(municipies, JsonRequestBehavior.AllowGet);

        }

        // GET: Solicitudes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var data = serv.SolicitudGet(id.Value);
            SolicitudViewModel viewModel = new SolicitudViewModel
            {
                Solicitud = data
            };
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }
        public ActionResult Create2()
        {
            return View();
        }

        // GET: Solicitudes/Create
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
            //  ViewBag.ProyectoEspecialMateriaGrupoID = new SelectList(db.ProyectoEspecialMateriaGrupo, "ProyectoEspecialMateriaGrupoID", "ProyectoEspecialMateriaGrupoID");
            return View();
        }

        // POST: Solicitudes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]        

        public ActionResult Create(SolicitudViewModel solicitudVM)
        {

            int soliId =0;
            if (ModelState.IsValid)
            {
                bool consulCedula = false;

                //if (solicitudVM.Solicitud)
                if (solicitudVM.Solicitud.GenericID_TipoIdentificacion == 10)
                    consulCedula = serv.SolicitudCheckCedula(solicitudVM.Solicitud.IdentificacionCedula.Replace("-", ""));

                if (consulCedula != true) {

                    solicitudVM.Solicitud.TieneInternet = solicitudVM.TieneInternetVal == 0 ? false : true;
                    solicitudVM.Solicitud.TieneLaptopPc = solicitudVM.TieneLaptopPcVal == 0 ? false : true;
                    solicitudVM.Solicitud.TieneSubsidio = solicitudVM.TieneSubsidioVal == 0 ? false : true;
                    solicitudVM.Solicitud.DireccionidMunicipio = solicitudVM.Solicitud.Idmunicipio;
                    var soli = serv.SolicitudAdd(solicitudVM.Solicitud);

                    

                    soliId = soli.SolicitudID;
                    string UploadPath = Server.MapPath("~/Files");
                    //Use Namespace called :  System.IO  


                    if (solicitudVM.PostFile != null)
                    {
                        string FileNameCedula = Path.GetFileName(solicitudVM.PostFile.FileName);
                        var FilePathCedula = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameCedula);
                        solicitudVM.PostFile.SaveAs(FilePathCedula);

                        SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                        {
                            SolicitudID = soliId,
                            IsActive = true,
                            ArchivoURL = "",
                            GenericID_TipoDocumento = 6,
                            LocalFile = FilePathCedula

                        };

                        serv.SolicitudAnexoAdd(solicitudAnexo);

                        //UploadFile(soli.SolicitudID, soli.Email, solicitudVM.PostFile, 6);
                    }
                    
                    if (solicitudVM.PostFileActa != null)
                    {
                        string FileNameActa = Path.GetFileName(solicitudVM.PostFileActa.FileName);
                        var FilePathActa = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameActa);
                        solicitudVM.PostFileActa.SaveAs(FilePathActa);

                        SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                        {
                            SolicitudID = soliId,
                            IsActive = true,
                            ArchivoURL = "",
                            GenericID_TipoDocumento = 7,
                            LocalFile = FilePathActa

                        };

                        serv.SolicitudAnexoAdd(solicitudAnexo);

                        //UploadFile(soli.SolicitudID, soli.Email, solicitudVM.PostFileActa, 7);

                    }

                    if (solicitudVM.PostFileEstudios != null)
                    {
                        string FileNameEstudios = Path.GetFileName(solicitudVM.PostFileEstudios.FileName);
                        var FilePathEstudios = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameEstudios);
                        solicitudVM.PostFileEstudios.SaveAs(FilePathEstudios);

                        SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                        {
                            SolicitudID = soliId,
                            IsActive = true,
                            ArchivoURL = "",
                            GenericID_TipoDocumento = 9,
                            LocalFile = FilePathEstudios

                        };

                        serv.SolicitudAnexoAdd(solicitudAnexo);
                    }

                    try
                    {

                        string codigo = serv.CodeSolicitudById(soli);

                        string emailBody = System.IO.File.ReadAllText(Server.MapPath(@"/Template/ITLA-Email.html")).Replace("@@email", solicitudVM.Solicitud.Nombres + " " + solicitudVM.Solicitud.Apellidos);

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
                new { controller = "Solicitudes", action = "NumeroSolicitud", Id = soliId}));

            }

            ViewBag.ProyectoEspecialMateriaGrupoID = new SelectList(serv.ProyectoEspecialMateriaGrupoList(), "ProyectoEspecialMateriaGrupoID", "ProyectoEspecialMateriaGrupoID", solicitudVM.Solicitud.ProyectoEspecialMateriaGrupoID);

            return View(solicitudVM.Solicitud);
        }

        // GET: Solicitudes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag._provinciasItems = ddg.getProvincias();

           


            var items = ddg.getAssigmentsAviable();
            ViewBag._proyectosEspItems = items;
            ViewBag._proyectosEspItems2 = items;
            ViewBag._generectTypeIdentification = ddg.getIdentificationType();
            ViewBag._generectTypeIngresoFamiliar = ddg.getIngresoFamiliar();
            ViewBag._getAcdemyLevel = ddg.getAcademicLevel();
            ViewBag._getTrueFalse = ddg.getTrueFalse();
            var solicitud = serv.SolicitudGet(id.Value);
            ViewBag._municipiosItems = ddg.getMuncicipiesDrop(solicitud.ProvinciaId);
            ViewBag.fechaFormat = solicitud.FechaNacimiento.ToString("dd-MM-yyyy");
            if (solicitud == null)
            {
                return HttpNotFound();
            }
         
            ViewBag.ProyectoEspecialMateriaGrupoID = new SelectList(serv.ProyectoEspecialMateriaGrupoList(), "ProyectoEspecialMateriaGrupoID", "ProyectoEspecialMateriaGrupoID", solicitud.ProyectoEspecialMateriaGrupoID);
            SolicitudViewModel solicitudVM = new SolicitudViewModel { 
                Solicitud = solicitud
            };


            return View(solicitudVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SolicitudViewModel solicitudVM)
        {
            if (ModelState.IsValid)
            {
                var soli= serv.SolicitudEdit(solicitudVM.Solicitud);


                string UploadPath = Server.MapPath("~/Files");
                //Use Namespace called :  System.IO  


                if (solicitudVM.PostFile != null)
                {
                    string FileNameCedula = Path.GetFileName(solicitudVM.PostFile.FileName);
                    var FilePathCedula = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameCedula);
                    solicitudVM.PostFile.SaveAs(FilePathCedula);

                    SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                    {
                        SolicitudID = soli.SolicitudID,
                        IsActive = true,
                        ArchivoURL = "",
                        GenericID_TipoDocumento = 6,
                        LocalFile = FilePathCedula

                    };

                    serv.SolicitudAnexoAdd(solicitudAnexo);

                    //UploadFile(soli.SolicitudID, soli.Email, solicitudVM.PostFile, 6);
                }

                if (solicitudVM.PostFileActa != null)
                {
                    string FileNameActa = Path.GetFileName(solicitudVM.PostFileActa.FileName);
                    var FilePathActa = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameActa);
                    solicitudVM.PostFileActa.SaveAs(FilePathActa);

                    SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                    {
                        SolicitudID = soli.SolicitudID,
                        IsActive = true,
                        ArchivoURL = "",
                        GenericID_TipoDocumento = 7,
                        LocalFile = FilePathActa

                    };

                    serv.SolicitudAnexoAdd(solicitudAnexo);

                    //UploadFile(soli.SolicitudID, soli.Email, solicitudVM.PostFileActa, 7);

                }

                if (solicitudVM.PostFileEstudios != null)
                {
                    string FileNameEstudios = Path.GetFileName(solicitudVM.PostFileEstudios.FileName);
                    var FilePathEstudios = Path.Combine(UploadPath, Guid.NewGuid().ToString() + FileNameEstudios);
                    solicitudVM.PostFileEstudios.SaveAs(FilePathEstudios);

                    SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                    {
                        SolicitudID = soli.SolicitudID,
                        IsActive = true,
                        ArchivoURL = "",
                        GenericID_TipoDocumento = 9,
                        LocalFile = FilePathEstudios

                    };

                    serv.SolicitudAnexoAdd(solicitudAnexo);
                }


                return RedirectToAction("Index");
            }
            return View(solicitudVM);
        }

        private void UploadFile(int solicitudID, string email, HttpPostedFileBase fileUpload, int genericID_TipoDocumento)
        {
            //foreach (var file in Page.file)
           
            if (fileUpload != null)
            {
                string UploadDirectory = "~/Accounts/";

                Directory.CreateDirectory(Server.MapPath(UploadDirectory));

                string path = Path.Combine(Server.MapPath(UploadDirectory),
                                                      Guid.NewGuid().ToString() + Path.GetFileName(fileUpload.FileName));

                fileUpload.SaveAs(path);

                SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                {
                    SolicitudID = solicitudID,
                    IsActive = true,
                    ArchivoURL = "",
                    GenericID_TipoDocumento = genericID_TipoDocumento,
                    LocalFile = path
                    
                };

                serv.SolicitudAnexoAdd(solicitudAnexo);



                ////Subir en el drive
                //GoogleDrive googleDrive = new GoogleDrive(Server.MapPath("~/Google/credentials.json"), Server.MapPath("~/Google/token.json"));

                //var companyFolder = googleDrive.GetFolder("1").FirstOrDefault();
                //{
                //    if (companyFolder != null)
                //    {
                //        var generalAccountFolder = googleDrive.GetFolder("Account", companyFolder.Id).FirstOrDefault();
                //        if (generalAccountFolder != null)
                //        {
                //            var userAccountFolder = googleDrive.GetFolder(email, generalAccountFolder.Id).FirstOrDefault();
                //            if (userAccountFolder == null)
                //            {
                //                userAccountFolder = googleDrive.CreateFolder(email, generalAccountFolder.Id);
                //            }

                //            string ImgUrl = string.Empty;

                //            var uploadedFile = googleDrive.UploadFile(fileUpload.FileName, path, fileUpload.ContentType, userAccountFolder.Id);

                //            googleDrive.ShareableFileById(uploadedFile.Id);

                //            ImgUrl = "https://drive.google.com/uc?id=" + uploadedFile.Id + "&export=view";


                //            SolicitudAnexo solicitudAnexo = new SolicitudAnexo
                //            {
                //                SolicitudID = solicitudID,
                //                IsActive = true,
                //                ArchivoURL = ImgUrl,
                //                GenericID_TipoDocumento = genericID_TipoDocumento,
                //                LocalFile = Server.MapPath(path)
                //            };

                //            serv.SolicitudAnexoAdd(solicitudAnexo);

                //        }
                //    }
                //}

                //try
                //{
                //    Directory.Delete(Server.MapPath(path), true);
                //}
                //catch
                //{

                //}
            }
        }

        public JsonResult validateCedula(string cedula)
        {
            var message = "";
            var consulCedula = serv.SolicitudCheckCedula(cedula.Replace("-", ""));
            if (consulCedula == true)
            {
                message = "Esta cedula ya se encuentra registrada";
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public JsonResult validateEmail(string email)
        {
            var message = "";
            var consulCedula = serv.SolicitudCheckEmail(email);
            if (consulCedula == true)
            {
                message = "Este correo ya se encuentra registrado";
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Find(string id)
        {


            if (!String.IsNullOrEmpty(id) && id != "undefined")
            {
                int idSolicitud = serv.IdByCodeSolicitud(id);
                if (idSolicitud != 0)
                {
                    var data = serv.SolicitudGet(idSolicitud);
                    return View(data);
                }
                else
                {
                    ViewBag.Numero = id;
                    return View();
                }

            }
            else
            {

                ViewBag.Mensaje = "No Existe";
                return RedirectToAction("Index", "Home");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                serv.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}