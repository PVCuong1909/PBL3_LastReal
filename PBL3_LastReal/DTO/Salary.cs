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
    
    public partial class Salary
    {
        public int ID_Salary { get; set; }
        public Nullable<int> ID_Person { get; set; }
        public Nullable<int> Salary1 { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
