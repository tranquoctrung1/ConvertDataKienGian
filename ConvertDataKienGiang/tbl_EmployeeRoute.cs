//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertDataKienGiang
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_EmployeeRoute
    {
        public long EmployeeRouteID { get; set; }
        public long EmployeeID { get; set; }
        public System.DateTime Period { get; set; }
        public int RouteID { get; set; }
        public Nullable<System.DateTime> AssignDate { get; set; }
        public Nullable<short> Received { get; set; }
        public Nullable<short> Send { get; set; }
    }
}