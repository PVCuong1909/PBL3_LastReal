//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3_LastReal.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public int ID_History { get; set; }
        public string ID_Account { get; set; }
        public Nullable<int> ID_Computer { get; set; }
        public Nullable<System.DateTime> TimeBegin { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Computer Computer { get; set; }
    }
}