//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITLA_PE_MVC.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemAttribute()
        {
            this.UsertTypeSystemAttribute = new HashSet<UsertTypeSystemAttribute>();
        }
    
        public int SystemAttributeID { get; set; }
        public string AttributeName { get; set; }
        public bool IsPageType { get; set; }
        public string PageUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsertTypeSystemAttribute> UsertTypeSystemAttribute { get; set; }
    }
}
