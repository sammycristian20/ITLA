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
    
    public partial class SolicitudAnexo
    {
        public int SolicitudAnexoID { get; set; }
        public int SolicitudID { get; set; }
        public int GenericID_TipoDocumento { get; set; }
        public string ArchivoURL { get; set; }
        public bool IsActive { get; set; }
        public string LocalFile { get; set; }
        public string WebURL { get; set; }
    
        public virtual Solicitud Solicitud { get; set; }
    }
}
