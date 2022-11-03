using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data
{
    public class BackUpContext : IdentityDbContext
    {
        public BackUpContext(DbContextOptions<BackUpContext> options) : base (options)
        {
        }
        public DbSet<ComponentesMexica.Data.Models.Privilege> Privilege { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Employee> Employee { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Componente> Componente { get; set; }
        public DbSet<Edited> Edit { get; set; }
        public DbSet<Entidades> Entidad { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Category> Category { get; set; }
    }
}
