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
    
    public partial class KHUVUC
    {
        public KHUVUC()
        {
            this.DUONGPHOes = new HashSet<DUONGPHO>();
            this.KHACHHANGs = new HashSet<KHACHHANG>();
            this.PHUONGs = new HashSet<PHUONG>();
            this.TIEUTHUs = new HashSet<TIEUTHU>();
        }
    
        public string MAKV { get; set; }
        public string TENKV { get; set; }
        public Nullable<int> THUTU { get; set; }
        public Nullable<bool> HIENTHI { get; set; }
        public Nullable<int> NHOMKV { get; set; }
        public Nullable<decimal> HSVATTU { get; set; }
        public Nullable<decimal> HSNC { get; set; }
        public string MAHD { get; set; }
    
        public virtual ICollection<DUONGPHO> DUONGPHOes { get; set; }
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
        public virtual ICollection<PHUONG> PHUONGs { get; set; }
        public virtual ICollection<TIEUTHU> TIEUTHUs { get; set; }
    }
}
