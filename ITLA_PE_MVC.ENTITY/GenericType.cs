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
    
    public partial class GenericType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GenericType()
        {
            this.Generics = new HashSet<Generic>();
        }
    
        public string GenericTypeCode { get; set; }
        public string GenericTypeDescription { get; set; }
        public bool IsUserEditable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Generic> Generics { get; set; }
    }
}
