//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITLA_PE_MVC.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitud()
        {
            this.SolicitudAnexoes = new HashSet<SolicitudAnexo>();
        }
    
        public int SolicitudID { get; set; }
        public int ProyectoEspecialMateriaGrupoID { get; set; }
        public Nullable<int> ProyectoEspecialMateriaGrupoIDSegundaOpcion { get; set; }
        public string CodigoSolicitud { get; set; }
        public System.Guid RowID { get; set; }
        public byte[] RowVersion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string Email { get; set; }
        public int GenericID_TipoIdentificacion { get; set; }
        public int GenericID_EstatusSolicitud { get; set; }
        public string IdentificacionCedula { get; set; }
        public string IdentificacionGenerada { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string TelResidencial { get; set; }
        public string TelCelular { get; set; }
        public int DireccionidMunicipio { get; set; }
        public string DireccionCalleNumero { get; set; }
        public int GenericID_NivelAcademico { get; set; }
        public string ResultadoComentario { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> Ingreso_Familiar { get; set; }
        public Nullable<bool> TieneInternet { get; set; }
        public Nullable<bool> TieneLaptopPc { get; set; }
        public Nullable<bool> TieneSubsidio { get; set; }
        public Nullable<bool> PreValidado { get; set; }
        public string PrevalidacionEstatus { get; set; }
        public Nullable<bool> PrevalidacionIdentificacionValida { get; set; }
        public Nullable<bool> PrevalidacionRecordValido { get; set; }
        public Nullable<decimal> PrevalidacionIndice { get; set; }
        public Nullable<int> PrevalidacionUserId { get; set; }
        public Nullable<System.DateTime> PrevalidacionLastDate { get; set; }
        public Nullable<System.DateTime> LastUserUpdate { get; set; }
        public string Genero { get; set; }
        public Nullable<int> MJFormID { get; set; }
        public Nullable<bool> CumpleRequisitosMinimos { get; set; }
        public Nullable<int> RankingIndice { get; set; }
        public string CriterioRankingIndice { get; set; }
        public Nullable<int> GrupoID1 { get; set; }
        public Nullable<int> GrupoID2 { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public Nullable<int> EstudianteID { get; set; }
    
        public virtual ProyectoEspecialMateriaGrupo ProyectoEspecialMateriaGrupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudAnexo> SolicitudAnexoes { get; set; }
    }
}
