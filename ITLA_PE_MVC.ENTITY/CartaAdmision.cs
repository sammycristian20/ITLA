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
    
    public partial class CartaAdmision
    {
        public int CartaAdmisionID { get; set; }
        public int IDEstudiante { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public bool EmailEnviado { get; set; }
        public string ExcepcionDetalle { get; set; }
    }
}
