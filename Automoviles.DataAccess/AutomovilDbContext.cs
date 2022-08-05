using Automoviles.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Automoviles.DataAccess
{
    public class AutomovilDbContext : DbContext
    {
        public AutomovilDbContext(DbContextOptions<AutomovilDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");
        //    optionsBuilder.UseSqlServer(@"Server=sbadesa017;Database=ACADEMY_NET_SOFIA;User Id = net_sofia; Password=Academy_2022");
        //    //comentar OnConfiguring  cuando  se configure en BASE del constructor
        //}

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Color> Colores { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        
    }
}
