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
    
    public partial class t_Alarm_Warning
    {
        public long Id { get; set; }
        public string SiteId { get; set; }
        public string ChannelId { get; set; }
        public string RangeName { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public Nullable<decimal> Lower { get; set; }
        public Nullable<decimal> Upper { get; set; }
        public string Notes { get; set; }
    }
}
