﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatinAlma
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OBA_ELEKTRAEntities : DbContext
    {
        public OBA_ELEKTRAEntities()
            : base("name=OBA_ELEKTRAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<USER_TAKVIM> USER_TAKVIM { get; set; }
        public virtual DbSet<USERD> USERD { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<MUH_SATINALMA> MUH_SATINALMA { get; set; }
        public virtual DbSet<QMUH_SATINALMA> QMUH_SATINALMA { get; set; }
    }
}
