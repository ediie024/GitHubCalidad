using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyProCalidad.Models;

namespace SpotifyProCalidad.BD.Maps
{
    public class CancionConfiguration : IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.ToTable("Cancion");
            builder.HasKey(o => o.Id);
            
            builder.HasMany(o => o.DetalleListaReproduccionCanciones).
                WithOne(o=>o.Cancion).
                HasForeignKey(o => o.IdCancion);
        }
    }
}