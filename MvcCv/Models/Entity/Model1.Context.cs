﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities2 : DbContext
    {
        public DbCvEntities2()
            : base("name=DbCvEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public virtual DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblSertifikalarim> TblSertifikalarim { get; set; }
        public virtual DbSet<TblYetenekler> TblYetenekler { get; set; }
        public virtual DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }
    }
}
