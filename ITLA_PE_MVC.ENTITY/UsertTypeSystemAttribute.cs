
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