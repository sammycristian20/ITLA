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
    
    public partial class ProyectoEspecial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProyectoEspecial()
        {
            this.ProyectoEspecialMateriaGrupoes = new HashSet<ProyectoEspecialMateriaGrupo>();
        }
    
        public int ProyectoEspecialID { get; set; }
        public System.Guid RowID { get; set; }
        public byte[] RowVersion { get; set; }
        public string ProyectoEspeciaNombre { get; set; }
        public string ProyectoEspecialDescripción { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> FechaAdmisionDesde { get; set; }
        public Nullable<System.DateTime> FechaAdmisionHasta { get; set; }
        public string PrefijoSolicitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProyectoEspecialMateriaGrupo> ProyectoEspecialMateriaGrupoes { get; set; }
    }
}
