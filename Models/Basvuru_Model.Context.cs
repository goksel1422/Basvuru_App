﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Basvuru_App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class basvuruEntities : DbContext
    {
        public basvuruEntities()
            : base("name=basvuruEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<basari_seviyeleri> basari_seviyeleri { get; set; }
        public DbSet<basvuru_durumu> basvuru_durumu { get; set; }
        public DbSet<bolumler> bolumler { get; set; }
        public DbSet<fakulteler> fakulteler { get; set; }
        public DbSet<ilceler> ilceler { get; set; }
        public DbSet<iller> iller { get; set; }
        public DbSet<projeler> projeler { get; set; }
        public DbSet<sem_kurs> sem_kurs { get; set; }
        public DbSet<universiteler> universiteler { get; set; }
        public DbSet<yetkiler> yetkiler { get; set; }
        public DbSet<referanslar> referanslar { get; set; }
        public DbSet<askerlik> askerlik { get; set; }
        public DbSet<diller> diller { get; set; }
        public DbSet<byabancidil> byabancidil { get; set; }
        public DbSet<deneyim> deneyim { get; set; }
        public DbSet<meslekler> meslekler { get; set; }
        public DbSet<kullanicilar> kullanicilar { get; set; }
        public DbSet<basvurular> basvurular { get; set; }
        public DbSet<sertifikalar> sertifikalar { get; set; }
    }
}
