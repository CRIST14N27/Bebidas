using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentadeBebidas.Context
{
    public class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server = localhost; database=ProyectoDb23cv; user=root; password= ");

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Vendedor> vendedor { get; set; }
    }
}
