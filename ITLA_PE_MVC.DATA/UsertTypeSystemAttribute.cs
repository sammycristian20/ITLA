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
    
    public partial class UsertTypeSystemAttribute
    {
        public int UsertTypeSystemAttributeID { get; set; }
        public byte[] rowversion { get; set; }
        public System.Guid rowid { get; set; }
        public System.DateTime createdate { get; set; }
        public string UserTypeCode { get; set; }
        public int SystemAttributeID { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public int LoginSessionID { get; set; }
    
        public virtual SystemAttribute SystemAttribute { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
