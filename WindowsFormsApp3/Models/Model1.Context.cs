﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Rent_MallEntities : DbContext
    {
        public Rent_MallEntities()
            : base("name=Rent_MallEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Mall> Mall { get; set; }
        public virtual DbSet<Pavilion> Pavilion { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Tenants> Tenants { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
