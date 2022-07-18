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

        public DbSet<ProjetoWEB.Models.Department> Department { get; set; } = default!;
    }
}
