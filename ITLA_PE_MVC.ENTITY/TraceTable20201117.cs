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
    
    public partial class TraceTable20201117
    {
        public int RowNumber { get; set; }
        public Nullable<int> EventClass { get; set; }
        public string TextData { get; set; }
        public string ApplicationName { get; set; }
        public string NTUserName { get; set; }
        public string LoginName { get; set; }
        public Nullable<int> CPU { get; set; }
        public Nullable<long> Reads { get; set; }
        public Nullable<long> Writes { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<int> ClientProcessID { get; set; }
        public Nullable<int> SPID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public byte[] BinaryData { get; set; }
    }
}
