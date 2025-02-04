﻿using BoosterConf.Ef.Ninja.TaskC.Storage.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BoosterConf.Ef.Ninja.TaskC.Storage
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options){ }

        public DbSet<Entities.ClaimStatusEntity> ClaimStatuses => Set<Entities.ClaimStatusEntity>();

        public DbSet<Entities.CoverTypeEntity> CoverTypes => Set<Entities.CoverTypeEntity>();

        public DbSet<Entities.CustomerEntity> Customers => Set<Entities.CustomerEntity>();

        public DbSet<Entities.CustomerAddressEntity> CustomerAddresses => Set<Entities.CustomerAddressEntity>();

        public DbSet<Entities.CoverEntity> Covers => Set<Entities.CoverEntity>();

        public DbSet<Entities.ClaimEntity> Claims => Set<Entities.ClaimEntity>();

        public DbSet<Entities.LifeClaimEntity> LifeClaims => Set<Entities.LifeClaimEntity>();

        public DbSet<Entities.AutoClaimEntity> AutoClaims => Set<Entities.AutoClaimEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureEntities(modelBuilder: modelBuilder);
            base.OnModelCreating(modelBuilder: modelBuilder);    
        }

        private void ConfigureEntities(ModelBuilder modelBuilder)
        {
            ClaimEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.ClaimEntity>());
            ClaimStatusEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.ClaimStatusEntity>());
            CoverEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.CoverEntity>());
            CoverTypeEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.CoverTypeEntity>());
            CustomerAddressEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.CustomerAddressEntity>());
            CustomerEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.CustomerEntity>());        
            
            //Table-per-type inheritance
            LifeClaimEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.LifeClaimEntity>());   
            AutoClaimEntityConfiguration.Configure(builder: modelBuilder.Entity<Entities.AutoClaimEntity>());   
        }
    }
}