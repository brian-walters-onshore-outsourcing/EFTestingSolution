﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLTodayLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sqltodayEntities : DbContext
    {
        public sqltodayEntities()
            : base("name=sqltodayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<QDEL> QDELs { get; set; }
        public virtual DbSet<QDEPT> QDEPTs { get; set; }
        public virtual DbSet<QEMP> QEMPs { get; set; }
        public virtual DbSet<QITEM> QITEMs { get; set; }
        public virtual DbSet<QSALE> QSALEs { get; set; }
        public virtual DbSet<QSPL> QSPLs { get; set; }
    }
}
