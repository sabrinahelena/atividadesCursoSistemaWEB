using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWEB.Models;

namespace ProjetoWEB.Data
{
    public class ProjetoWEBContext : DbContext
    {
        public ProjetoWEBContext (DbContextOptions<ProjetoWEBContext> options)
            : base(options)
        {
        }

        public ProjetoWEBContext()
        {
        }

        public DbSet<ProjetoWEB.Models.Department> Department { get; set; } = default!;
        public DbSet<ProjetoWEB.Models.Employees> Employees { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable("Departments")
                .HasKey(t => t.Id);
       
            modelBuilder.Entity<Employees>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Department>()
                .ToTable("Departments")    
                .HasMany(t => t.Employees);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder Config)
        {
            String Credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Config.UseSqlServer(Credencial);
        }

        public DbSet<ProjetoWEB.Models.Employees>? Employeess { get; set; }

    }
}
