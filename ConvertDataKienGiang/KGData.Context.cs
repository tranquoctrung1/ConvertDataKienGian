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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EOSKG_WebAppEntities : DbContext
    {
        public EOSKG_WebAppEntities()
            : base("name=EOSKG_WebAppEntities")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 0;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<TIEUTHU> TIEUTHUs { get; set; }
        public DbSet<DUONGPHO> DUONGPHOes { get; set; }
        public DbSet<KHUVUC> KHUVUCs { get; set; }
        public DbSet<PHUONG> PHUONGs { get; set; }
    }
}
