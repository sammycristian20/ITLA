
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
    
public partial class Generic
{

    public int GenericID { get; set; }

    public string GenericType { get; set; }

    public string GenericDescription { get; set; }

    public Nullable<int> LastLoginSessionID { get; set; }

    public Nullable<System.DateTime> LastUpdateDate { get; set; }

    public bool IsActive { get; set; }

    public Nullable<int> OrderIndex { get; set; }

    public Nullable<decimal> NumericValue { get; set; }



    public virtual GenericType GenericType1 { get; set; }

}

}
