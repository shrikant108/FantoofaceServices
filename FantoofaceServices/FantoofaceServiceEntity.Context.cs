﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FantoofaceServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FantoofaceService_dbEntities : DbContext
    {
        public FantoofaceService_dbEntities()
            : base("name=FantoofaceService_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Tbl_Application> Tbl_Application { get; set; }
        public DbSet<Tbl_Category> Tbl_Category { get; set; }
        public DbSet<tbl_Tutorial> tbl_Tutorial { get; set; }
    }
}
