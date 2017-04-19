﻿using Library.Domain.Entities;
using Library.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Library.Infra.Data.Context
{
    public class ProjectModelContext : DbContext
    {

        public ProjectModelContext()
            : base("ProjectModelContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // General configurations
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "ID")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // Specifc configurations
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new BookConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where( entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("RegistrationDate").IsModified = false;

            }
            return base.SaveChanges();
        }
    }
}
