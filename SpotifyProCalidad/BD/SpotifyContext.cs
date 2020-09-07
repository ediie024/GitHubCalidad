using Microsoft.EntityFrameworkCore;
using SpotifyProCalidad.BD.Maps;
using SpotifyProCalidad.Models;

namespace SpotifyProCalidad.BD
{
    public class SpotifyContext : DbContext
    {
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<ListaRepoduccion> ListaReproducciones { get; set; }
        public DbSet<DetalleListaReproduccionCancion> DetalleListaReproduccionCanciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Server=DESKTOP-6AL815O\\SQLEXPRESS; DataBase=SpotifyProCalidad;Trusted_Connection=True;MultipleActiveResultSets=true");
             optionsBuilder.UseSqlServer("Data Source=SQL5080.site4now.net;Initial Catalog=DB_A6707F_SpotifyProCalidad;User Id=DB_A6707F_SpotifyProCalidad_admin;Password=Locosport24@");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          modelBuilder.ApplyConfiguration(new CancionConfiguration());
          modelBuilder.ApplyConfiguration(new ListaReproduccionConfiguration());  
          modelBuilder.ApplyConfiguration(new DetalleListaReproduccionCancionConfiguration());
        }
    }
}