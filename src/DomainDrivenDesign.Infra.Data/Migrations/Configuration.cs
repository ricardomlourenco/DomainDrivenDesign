namespace DomainDrivenDesign.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DomainDrivenDesign.Domain.Entities;
    using DomainDrivenDesign.Infra.Data.Context;
    using DomainDrivenDesign.Infra.Data.Migrations.Seed;

    internal sealed class Configuration : DbMigrationsConfiguration<DefaultORMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DefaultORMContext context)
        {
            context.Securities.AddOrUpdate<Security>(SecuritySeed.Seed().ToArray());
            context.SaveChanges();
        }
    }
}
