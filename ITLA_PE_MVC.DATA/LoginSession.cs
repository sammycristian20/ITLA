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
    
    public partial class LoginSession
    {
        public int LoginSessionID { get; set; }
        public byte[] rowversion { get; set; }
        public System.Guid rowid { get; set; }
        public System.DateTime createdate { get; set; }
        public int UserID { get; set; }
        public string IpAddress { get; set; }
        public string HostName { get; set; }
    
        public virtual User User { get; set; }
    }
}
