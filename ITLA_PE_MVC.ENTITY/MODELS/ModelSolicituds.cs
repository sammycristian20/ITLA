using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLA_PE_MVC.ENTITY.MODELS
{
    public class ModelSolicituds
    {

        [Required]
        public int ProyectoEspecialMateriaGrupoID { get; set; }

        public Nullable<int> ProyectoEspecialMateriaGrupoIDSegundaOpcion { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int GenericID_TipoIdentificacion { get; set; }

        [Required]
        public string IdentificacionCedula { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime FechaNacimiento { get; set; }
        
        public string TelResidencial { get; set; }
        
        public string TelCelular { get; set; }
        [Required]
        public int DireccionidMunicipio { get; set; }
        [Required]
        public string DireccionCalleNumero { get; set; }
        [Required]
        public int GenericID_NivelAcademico { get; set; }
        public string ResultadoComentario { get; set; }
        [Required]
        public int ProvinciaId { get; set; }
        [Required]
        public int Idmunicipio { get; set; }

        public string CodigoSolicitud { get; set; }

        public int Ingreso_Familiar { get; set; }
        public bool TieneInternet { get; set; }
        public bool TieneLaptopPc { get; set; }
        public bool TieneSubsidio { get; set; }

        //campos para llenar opciones
        public int IdSolicituds { get; set; }
        public string NoSolicitud { get; set; }
        public int GenericID_EstatusSolicitud { get; set; }
        public string ProvinciaDesc { get; set; }
        public string MunicipioDesc { get; set; }
        public string DocumentoTipoDesc { get; set; }
        public string StatusDesc { get; set; }
        public string NivelAcademicoDesc { get; set; }
        public string ProyectoEspecialMateriaGrupoDesc1 { get; set; }
        public string ProyectoEspecialMateriaGrupoDesc2 { get; set; }
        public virtual ICollection<SolicitudAnexo> SolicitudAnexo { get; set; }
    }
}
