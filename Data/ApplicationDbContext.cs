using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ComponentesMexica.Data.Models;
using ComponentesMexica.Data.TempModels;

namespace ComponentesMexica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ComponentesMexica.Data.Models.Privilege> Privilege { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Employee> Employee { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Componente> Componente { get; set; }
        public DbSet<Edited> Edit { get; set; }
        public DbSet<Entidades> Entidad { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Category> Category { get; set; }
        public DbSet<EntityDataLoaded> DataEntity { get; set; }
        public DbSet<ComponentesMexica.Data.Models.PromoCodes> PromoCodes { get; set; }
        public DbSet<ComponentesMexica.Data.Models.PCMR> PCMR { get; set; }
        public DbSet<ShoppingCartItem> shoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<TempOrder> tempOrders { get; set; }
        public DbSet<TempModels.TempComponent> tempComponents { get; set; }
        public DbSet<UsedPromos> UsedPromos { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<ErrorReporter> Reporters { get; set; }
        public DbSet<ComponentesMexica.Data.Models.SecondHand> SecondHand { get; set; }
        public DbSet<ComponentesMexica.Data.Models.Vendedor> Vendedor { get; set; }
        public DbSet<Identificadores> Identificador { get; set; }
        public DbSet<SellerM> Nomina { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<SellerOrders> OrdersSeller { get; set; }
        public DbSet<SellerReports> RerporteSeller { get; set; }
        public DbSet<SellerRetire> RetiroDinero { get; set; }
        public DbSet<Rifas> Rifas { get; set; }
        public DbSet<GanadorRifa> Ganadores { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<RifaOrder> RifaOrders { get; set; }
        public DbSet<Timer> Timer { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<PWDLog> pWDLogs { get; set; }
    }
}
