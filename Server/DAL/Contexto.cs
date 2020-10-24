using Microsoft.EntityFrameworkCore;
using PedidosBlazorWebAssembly.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazorWebAssembly.Server.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\OrdenDB.db");
        }

        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //[ForeignKey("ordenId")]
            modelBuilder.Entity<OrdenesDetalle>().HasKey(sc => new { sc.ordenId, sc.productoId });


            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                productoId = 1,
                descripcion = "Queso",
                costo = 250,
                inventario = 0
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                suplidorId = 1,
                nombre = "Jeo"
            });



        }
    }
}