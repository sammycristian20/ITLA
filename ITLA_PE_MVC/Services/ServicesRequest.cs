using ITLA_PE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ITLA_PE_MVC.ENTITY;

namespace ITLA_PE_MVC.Services
{
    public class ServicesRequest
    {
        ITLA_PE_MVC.ORBIPEEntities dbContext = null;

        public ServicesRequest()
        {
            dbContext = new ITLA_PE_MVC.ORBIPEEntities();
        }

        public Solicituds SolicitudGet(int id) {
            var obj = dbContext.Solicitud.Find(id);
            var Result = new Solicituds {
                Nombres = obj.Apellidos,
                Apellidos = obj.Nombres,
                GenericID_NivelAcademico = obj.GenericID_NivelAcademico,
                SolicitudAnexo = obj.SolicitudAnexo,
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
                ProvinciaDesc = GetProvinciasRD().Where(p => p.IDprovincia == obj.ProvinciaId).FirstOrDefault().ProvinciaNombre,
                MunicipioDesc = GetMunicipiosPorProvincia(obj.ProvinciaId.Value).Where(p=>p.IDmunicipio==obj.DireccionidMunicipio).FirstOrDefault().Municipio,
                ProvinciaId = obj.ProvinciaId.Value,
                IdSolicituds = obj.SolicitudID,
                NivelAcademicoDesc = GenericItems("NivelAcademico").Where(p=>p.GenericID==obj.GenericID_NivelAcademico).FirstOrDefault().GenericDescription,
                DocumentoTipoDesc = GenericItems("TipoIdentificacion").Where(p => p.GenericID == obj.GenericID_TipoIdentificacion).FirstOrDefault().GenericDescription,
                NoSolicitud = obj.CodigoSolicitud,
                ProyectoEspecialMateriaGrupoDesc1 =  GetMateriasDisponibles().Where(p=>p.ProyectoEspecialMateriaGrupoID==obj.ProyectoEspecialMateriaGrupoID).FirstOrDefault().Materia,
                ProyectoEspecialMateriaGrupoDesc2 = GetMateriasDisponibles().Where(p => p.ProyectoEspecialMateriaGrupoID == obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion).FirstOrDefault().Materia,
                StatusDesc = GenericItems("EstatusSolicitud").Where(p => p.GenericID == obj.GenericID_EstatusSolicitud).FirstOrDefault().GenericDescription,
                
            };
            return Result; 
        
        }

        
        public void SolicitudUpdate(Solicitud obj) { dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified; dbContext.SaveChanges(); ; }
        public Solicitud SolicitudAdd(Solicituds obj) {
            var guid = new Guid();

            Guid guids = Guid.NewGuid();
            var solicitud = new Solicitud
            {
                Nombres = obj.Apellidos,
                Apellidos = obj.Nombres,
                GenericID_NivelAcademico = obj.GenericID_NivelAcademico,
                SolicitudAnexo = obj.SolicitudAnexo,
                DireccionCalleNumero = obj.DireccionCalleNumero,
                DireccionidMunicipio = obj.DireccionidMunicipio,
                Email = obj.Email, FechaNacimiento = obj.FechaNacimiento,
                GenericID_TipoIdentificacion = obj.GenericID_TipoIdentificacion,
                IdentificacionCedula = obj.IdentificacionCedula,
                ProyectoEspecialMateriaGrupoID = obj.ProyectoEspecialMateriaGrupoID,
                ResultadoComentario = obj.Apellidos,
                ProyectoEspecialMateriaGrupoIDSegundaOpcion = obj.ProyectoEspecialMateriaGrupoIDSegundaOpcion,
                TelCelular = obj.TelCelular,
                TelResidencial = obj.TelResidencial,
                RowID = guids,
                ProvinciaId = obj.ProvinciaId,
                //RowVersion = obj.RowVersion,
                FechaCreacion = DateTime.Now,
                //CodigoSolicitud = obj.Apellidos,
                GenericID_EstatusSolicitud = 3,
            };
            var result =  dbContext.Solicitud.Add(solicitud); 
            dbContext.SaveChanges();
            return result;
        }
        public List<Solicitud> SolicitudList() { return dbContext.Solicitud.ToList(); }

        public bool SolicitudCheckCedula(string cedula)
        {
            return dbContext.Solicitud.Any(set => set.IdentificacionCedula == cedula);
        }

        public bool SolicitudCheckEmail(string email)
        {
            return dbContext.Solicitud.Any(set => set.Email == email);
        }

        public bool SolicitudCheckIdentifiacionGenerada(string otraIdentificacion)
        {
            return dbContext.Solicitud.Any(set => set.IdentificacionGenerada == otraIdentificacion);
        }

        public List<UspGenericItems_Result> GenericItems(string genericType)
        {
            return dbContext.UspGenericItems(genericType).ToList();
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

        public SolicitudAnexo SolicitudAnexoGet(int id) { return dbContext.SolicitudAnexo.Find(id); }
        public void SolicitudAnexoUpdate(SolicitudAnexo obj) { dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified; dbContext.SaveChanges(); ; }
        public void SolicitudAnexoAdd(SolicitudAnexo obj) { dbContext.SolicitudAnexo.Add(obj); dbContext.SaveChanges(); }
        public List<SolicitudAnexo> SolicitudAnexoList() { return dbContext.SolicitudAnexo.ToList(); }


        public void Dispose()
        {
            if (dbContext != null)
                ((IDisposable)dbContext).Dispose();
        }
    }
}