﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ITLA_PE_MVC.DATA;
using ITLA_PE_MVC.ENTITY;
using ITLA_PE_MVC.ENTITY.MODELS;

namespace ITLA_PE_MVC.SERVICE
{
    public class ServicesRequest
    {
        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServicesRequest()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        public ModelSolicituds SolicitudGet(int id)
        {


            try
            {
                var obj = dbContext.Solicituds.Find(id);
                var _NivelAcademicoDesc = GenericItems("NivelAcademico").Where(p => p.GenericID == obj.GenericID_NivelAcademico).FirstOrDefault().GenericDescription;
                var _DocumentoTipoDesc = GenericItems("TipoIdentificacion").Where(p => p.GenericID == obj.GenericID_TipoIdentificacion).FirstOrDefault().GenericDescription;
                var _ProyectoEspecialMateriaGrupoDesc1 = GetMateriasDisponibles().Where(p => p.ProyectoEspecialMateriaGrupoID == obj.ProyectoEspecialMateriaGrupoID).FirstOrDefault().Materia;
                var _ProyectoEspecialMateriaGrupoDesc2 = GetMateriasDisponibles().Where(p => p.ProyectoEspecialMateriaGrupoID == obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion).FirstOrDefault().Materia;
                var _StatusDesc = GenericItems("EstatusSolicitud").Where(p => p.GenericID == obj.GenericID_EstatusSolicitud).FirstOrDefault().GenericDescription;
                var _ProvinciaDesc = GetProvinciasRD().Where(p => p.IDprovincia == obj.ProvinciaId).FirstOrDefault().ProvinciaNombre;

                if (obj.DireccionidMunicipio.ToString() != "-1")
                {
                var _MunicipioDesc = GetMunicipiosPorProvincia(obj.ProvinciaId.Value).Where(p => p.IDmunicipio == obj.DireccionidMunicipio).FirstOrDefault().Municipio;
                }
                var Result = new ModelSolicituds
                {
                    Nombres = obj.Apellidos,
                    Apellidos = obj.Nombres,
                    GenericID_NivelAcademico = obj.GenericID_NivelAcademico,
                    Ingreso_Familiar = obj.Ingreso_Familiar.Value,
                    DireccionCalleNumero = obj.DireccionCalleNumero,
                    DireccionidMunicipio = obj.DireccionidMunicipio,
                    Email = obj.Email,
                    FechaNacimiento = obj.FechaNacimiento,
                    GenericID_TipoIdentificacion = obj.GenericID_TipoIdentificacion,
                    IdentificacionCedula = obj.IdentificacionCedula,
                    Idmunicipio = obj.DireccionidMunicipio,
                    ProyectoEspecialMateriaGrupoID = obj.ProyectoEspecialMateriaGrupoID,
                    ResultadoComentario = obj.Apellidos,
                    ProyectoEspecialMateriaGrupoIDSegundaOpcion = obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion,
                    TelCelular = obj.TelCelular,
                    TelResidencial = obj.TelResidencial,
                    ProvinciaId = obj.ProvinciaId.Value,
                    IdSolicituds = obj.SolicitudID,
                    NoSolicitud = obj.CodigoSolicitud,
                    SolicitudAnexo = obj.SolicitudAnexoes,
                    NivelAcademicoDesc = _NivelAcademicoDesc,
                    DocumentoTipoDesc = _DocumentoTipoDesc,
                    ProyectoEspecialMateriaGrupoDesc1 = _ProyectoEspecialMateriaGrupoDesc1,
                    ProyectoEspecialMateriaGrupoDesc2 = _ProyectoEspecialMateriaGrupoDesc2,
                    StatusDesc = _StatusDesc,
                    ProvinciaDesc = _ProvinciaDesc,
                    //MunicipioDesc = _MunicipioDesc,
                    TieneInternet = obj.TieneInternet.Value,
                    TieneLaptopPc = obj.TieneLaptopPc.Value,
                    TieneSubsidio = obj.TieneSubsidio.Value
                };
                return Result;
            }
            catch (Exception ex)
            {
               // this.Logger(ex.ToString(), "ITLA_PE", "obtener Data Solicitud", "Error obteniendo solicitud");
                throw ex;
            }
           

        }

        public int IdByCodeSolicitud(string codeSolicitud)
        {
            int result = 0;

            var data = dbContext.Solicituds.Where(p => p.CodigoSolicitud == codeSolicitud
            || p.Email == codeSolicitud
            ).SingleOrDefault();

            if (data != null)
            {
                result = data.SolicitudID;
            }
            return result;
        }

        public string CodeSolicitudById(Solicitud obj)
        {
            dbContext.Entry(obj).State = System.Data.Entity.EntityState.Detached;

            var code = dbContext.Solicituds.Find(obj.SolicitudID).CodigoSolicitud;
            return code;
        }

        public string CodeIntencionById(Intencion obj)
        {
            dbContext.Entry(obj).State = System.Data.Entity.EntityState.Detached;

            var code = dbContext.Intencions.Find(obj.IntencionID).CodigoIntencion;
            return code;
        }




        public Solicitud CodeSolicitudById(int id)
        {
            //var obj = dbContext.Solicituds.Find(id);
            //dbContext.Entry(obj).State = EntityState.Detached;
            var data = dbContext.Solicituds.Find(id);
            return data;
        }

        public Intencion CodeIntencionById(int id)
        {
            //var obj = dbContext.Solicituds.Find(id);
            //dbContext.Entry(obj).State = EntityState.Detached;
            var data = dbContext.Intencions.Find(id);
            return data;
        }

        
        //  public void SolicitudUpdate(ModelSolicituds obj) { dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified; dbContext.SaveChanges(); ; }
        public Solicitud SolicitudAdd(ModelSolicituds obj)
        {
            //var guid = new Guid();
            try
            {
                Guid guids = Guid.NewGuid();
                var solicitud = new Solicitud
                {
                    Nombres = obj.Apellidos,
                    Apellidos = obj.Nombres,
                    GenericID_NivelAcademico = obj.GenericID_NivelAcademico,
                    SolicitudAnexoes = obj.SolicitudAnexo,
                    DireccionCalleNumero = obj.DireccionCalleNumero,
                    DireccionidMunicipio = obj.DireccionidMunicipio,
                    Email = obj.Email,
                    FechaNacimiento = obj.FechaNacimiento,
                    GenericID_TipoIdentificacion = obj.GenericID_TipoIdentificacion,
                    IdentificacionCedula = obj.IdentificacionCedula.Replace("-", ""),
                    ProyectoEspecialMateriaGrupoID = obj.ProyectoEspecialMateriaGrupoID,
                    ResultadoComentario = obj.Apellidos,
                    ProyectoEspecialMateriaGrupoIDSegundaOpcion = obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion,
                    TelCelular = obj.TelCelular,
                    TelResidencial = obj.TelResidencial,
                    RowID = guids,
                    ProvinciaId = obj.ProvinciaId,
                    Ingreso_Familiar = obj.Ingreso_Familiar,
                    TieneInternet = obj.TieneInternet,
                    TieneLaptopPc = obj.TieneLaptopPc,
                    TieneSubsidio = obj.TieneSubsidio,
                    FechaCreacion = DateTime.Now,
                    GenericID_EstatusSolicitud = 3,
                };
                var result = dbContext.Solicituds.Add(solicitud);
                dbContext.SaveChanges();
               // this.Logger("Solicitud Creada correctamente", "ITLA_PE", "SolicitudAdd", "Solicitud Creada para: "+ result.SolicitudID+" "+result.Nombres+" "+result.Apellidos);
                return result;
            }
            catch (Exception ex)
            {
               // this.Logger(ex.ToString(), "ITLA_PE", "SolicitudAdd", "Error creando solicitud");
                throw ex;
            }

           
        }

        public Intencion IntencionAdd(ModelIntencion obj)
        {
            //var guid = new Guid();
            try
            {
                Guid guids = Guid.NewGuid();
                var solicitud = new Intencion
                {
                    Nombres = obj.Nombres,
                    Apellidos = obj.Apellidos,
                    GenericID_NivelAcademico = obj.GenericID_NivelAcademico,                    
                    DireccionCalleNumero = obj.DireccionCalleNumero,
                    DireccionidMunicipio = obj.DireccionidMunicipio,
                    Email = obj.Email,
                    FechaNacimiento = obj.FechaNacimiento,
                    GenericID_TipoIdentificacion = obj.GenericID_TipoIdentificacion,
                    IdentificacionCedula = obj.IdentificacionCedula.Replace("-", ""),                    
                    ResultadoComentario = obj.Apellidos,
                    TelCelular = obj.TelCelular,
                    TelResidencial = obj.TelResidencial,
                    RowID = guids,
                    ProvinciaId = obj.ProvinciaId,
                    Ingreso_Familiar = obj.Ingreso_Familiar,
                    TieneInternet = obj.TieneInternet,
                    TieneLaptopPc = obj.TieneLaptopPc,
                    TieneSubsidio = obj.TieneSubsidio,
                    FechaCreacion = DateTime.Now,     
                    CarreraID = obj.CarreraID
                };
                var result = dbContext.Intencions.Add(solicitud);
                dbContext.SaveChanges();
                // this.Logger("Solicitud Creada correctamente", "ITLA_PE", "SolicitudAdd", "Solicitud Creada para: "+ result.SolicitudID+" "+result.Nombres+" "+result.Apellidos);
                return result;
            }
            catch (Exception ex)
            {
                // this.Logger(ex.ToString(), "ITLA_PE", "SolicitudAdd", "Error creando solicitud");
                throw ex;
            }



        }


        public Solicitud SolicitudEdit(ModelSolicituds obj)
        {
            try
            {
                var dae = dbContext.Solicituds.Find(obj.IdSolicituds);


                dae.Nombres = obj.Nombres;
                dae.Apellidos = obj.Apellidos;
                dae.GenericID_NivelAcademico = obj.GenericID_NivelAcademico;
                dae.SolicitudAnexoes = obj.SolicitudAnexo != null ? obj.SolicitudAnexo : dae.SolicitudAnexoes;
                dae.DireccionCalleNumero = obj.DireccionCalleNumero;
                dae.DireccionidMunicipio = obj.Idmunicipio;
                dae.Email = obj.Email;
                dae.FechaNacimiento = obj.FechaNacimiento;
                dae.GenericID_TipoIdentificacion = obj.GenericID_TipoIdentificacion;
                dae.IdentificacionCedula = obj.IdentificacionCedula.Replace("-", "");
                dae.ProyectoEspecialMateriaGrupoID = obj.ProyectoEspecialMateriaGrupoID;
                dae.ProyectoEspecialMateriaGrupoIDSegundaOpcion = obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion;
                dae.TelCelular = obj.TelCelular;
                dae.TelResidencial = obj.TelResidencial;
                dae.ProvinciaId = obj.ProvinciaId;
                dae.Ingreso_Familiar = obj.Ingreso_Familiar;
                dae.TieneInternet = obj.TieneInternet;
                dae.TieneLaptopPc = obj.TieneLaptopPc;
                dae.TieneSubsidio = obj.TieneSubsidio;
                dae.ResultadoComentario = "Solicitud modificada el " + DateTime.Now.ToString();
                dae.LastUserUpdate = DateTime.Now;


                dbContext.Entry(dae).State = EntityState.Modified;
                dbContext.SaveChanges();
                return dae;
            }
            catch (Exception ex)
            {
               // this.Logger(ex.ToString(), "ITLA_PE", "SolicitudEdit", "Error editando solicitud");
                throw;
            }
            
        }





        public List<Solicitud> SolicitudList()
        {
            return dbContext.Solicituds.Include("ProyectoEspecialMateriaGrupo").ToList();
        }

        public List<ProyectoEspecialMateriaGrupo> ProyectoEspecialMateriaGrupoList() { return dbContext.ProyectoEspecialMateriaGrupoes.ToList(); }

        public Solicitud SolicitudCheckCedula(string cedula)
        {
            return dbContext.Solicituds.Where(p =>p.IdentificacionCedula == cedula).FirstOrDefault();
        }

        public Intencion SolicitudCheckIntencionCedula(string cedula)
        {
            return dbContext.Intencions.Where(p => p.IdentificacionCedula == cedula).FirstOrDefault();
        }


        public Solicitud SolicitudCheckEmail(string email)
        {
            return dbContext.Solicituds.Where(p=>p.Email == email).FirstOrDefault();
        }

        public Intencion IntencionCheckCedula(string cedula)
        {
            return dbContext.Intencions.Where(p => p.IdentificacionCedula == cedula).FirstOrDefault();
        }


        public Intencion IntencionCheckEmail(string email)
        {
            return dbContext.Intencions.Where(p => p.Email == email).FirstOrDefault();
        }


        public bool SolicitudCheckIdentifiacionGenerada(string otraIdentificacion)
        {
            return dbContext.Solicituds.Any(set => set.IdentificacionGenerada == otraIdentificacion);
        }

        public List<UspGenericItems_Result> GenericItems(string genericType)
        {
            return dbContext.UspGenericItems(genericType).ToList();
        }


        public List<UspGetCarrera_Result> GetCarreras()
        {
            return dbContext.UspGetCarrera().ToList();
        }

        public List<UspProvinciasRD_Result> GetProvinciasRD()
        {
            return dbContext.UspProvinciasRD().ToList();
        }

        public List<GetMateriasDisponibles_Result> GetMateriasDisponibles()
        {
            return dbContext.GetMateriasDisponibles().ToList();
        }

        public List<UspMunicipiosPorProvincia_Result> GetMunicipiosPorProvincia(int idProvincia)
        {
            return dbContext.UspMunicipiosPorProvincia(idProvincia).ToList();
        }

        public SolicitudAnexo SolicitudAnexoGet(int id) { return dbContext.SolicitudAnexoes.Find(id); }
        public void SolicitudAnexoUpdate(SolicitudAnexo obj) {

            try
            {
                dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified; dbContext.SaveChanges();
              //  this.Logger("Anexos editados exitosamente", "ITLA_PE", "SolicitudAnexoUpdate", "Anexos editados");
            }
            catch (Exception ex)
            {
              //  this.Logger(ex.ToString(), "ITLA_PE", "Error Creando Anexos", "Error Anexos DbContext");
                throw;
            }


           
        }
        public void SolicitudAnexoAdd(SolicitudAnexo obj) {
            try
            {
                dbContext.SolicitudAnexoes.Add(obj); dbContext.SaveChanges();
               // this.Logger("Anexos Creados exitosamente", "ITLA_PE", "SolicitudAnexoAdd", "Anexos Enviados");
            }
            catch (Exception ex)
            {
               // this.Logger(ex.ToString(), "ITLA_PE", "Error Creando Anexos", "Error Anexos DbContext");
                throw;
            }
            
        
        }
        public List<SolicitudAnexo> SolicitudAnexoList() { return dbContext.SolicitudAnexoes.ToList(); }


        public bool sendEmail(Solicitud solicitud, string body)
        {

            bool status = false;
            try
            {
                if (solicitud != null)
                {
                    var senderEmail = new MailAddress("puntostecnologicos@itla.edu.do", "Itla Puntos Técnologicos");
                    var receiverEmail = new MailAddress(solicitud.Email, solicitud.Nombres + " " + solicitud.Apellidos);
                    var password = "2020puntostecnologicos";
                    var sub = "Solicitud de beca ITLA-MJ recibida";
                    //var body = "HTML";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = sub,
                        Body = body,
                        IsBodyHtml = true
                    })
                    {
                        smtp.Send(mess);
                    }
                    //this.Logger("Email Enviado Correctamente"+ solicitud.Email, "ITLA_PE", "EmailSender", "Email status True");
                    status = true;
                    return status;
                }
            }
            catch (Exception ex)
            {

               // this.Logger(ex.ToString(),"ITLA_PE","EmailSender","Error Email status False"+ solicitud.Email);
                status = false;
            }
            return status;
        }

        public bool sendEmail(Intencion solicitud, string body)
        {

            bool status = false;
            try
            {
                if (solicitud != null)
                {
                    var senderEmail = new MailAddress("puntostecnologicos@itla.edu.do", "Itla Puntos Técnologicos");
                    var receiverEmail = new MailAddress(solicitud.Email, solicitud.Nombres + " " + solicitud.Apellidos);
                    var password = "2020puntostecnologicos";
                    var sub = "Solicitud Intención Recibida";
                    //var body = "HTML";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = sub,
                        Body = body,
                        IsBodyHtml = true
                    })
                    {
                        smtp.Send(mess);
                    }
                    //this.Logger("Email Enviado Correctamente"+ solicitud.Email, "ITLA_PE", "EmailSender", "Email status True");
                    status = true;
                    return status;
                }
            }
            catch (Exception ex)
            {

                // this.Logger(ex.ToString(),"ITLA_PE","EmailSender","Error Email status False"+ solicitud.Email);
                status = false;
            }
            return status;
        }
        //Generador de logs recibe mensaje, apilcacion, modulo y tipo de aplicacion
        //public void Logger(String message, String app, string module = null, string logTypeDesc = null)
        //{
        //    var Logs = new Log
        //    {
        //        LogApp = app,
        //        LogMessage = message,
        //        LogModule = module,
        //        LogTypeDesc = logTypeDesc,
        //    };
        //    try
        //    {
        //        dbContext.Logs.Add(Logs);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}
        public void Dispose()
        {
            if (dbContext != null)
                ((IDisposable)dbContext).Dispose();
        }
    }
}