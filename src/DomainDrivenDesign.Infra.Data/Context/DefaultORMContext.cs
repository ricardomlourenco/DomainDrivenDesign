﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Infra.Data.Context
{
    [DbConfigurationType(typeof(DatabaseConfiguration))] 
    public class DefaultORMContext : DbContext
    {
        public DefaultORMContext(): base("DDDTemplate")
        {

        }

        public DbSet<Security> Securities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
