using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.entities;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class ProyectContext : DbContext
    {
        public ProyectContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
