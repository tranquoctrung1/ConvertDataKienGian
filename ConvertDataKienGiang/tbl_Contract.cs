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
    
    public partial class tbl_Contract
    {
        public long ContractID { get; set; }
        public string ContractCode { get; set; }
        public short ContractType { get; set; }
        public long RegisterID { get; set; }
        public long CustomerID { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public string ContractStatus { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public string ClockCode { get; set; }
        public Nullable<int> ClockTypeID { get; set; }
        public Nullable<System.DateTime> LastClockCheck { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public string ZoneCode { get; set; }
        public Nullable<double> Lon { get; set; }
        public Nullable<double> Lat { get; set; }
        public int Disable { get; set; }
    }
}
