using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyProCalidad.Models;

namespace SpotifyProCalidad.BD.Maps
{
    public class ListaReproduccionConfiguration: IEntityTypeConfiguration<ListaRepoduccion>
    {
        public void Configure(EntityTypeBuilder<ListaRepoduccion> builder)
        {
            builder.ToTable("ListaReproduccion");
            builder.HasKey(o => o.Id);
           
            //detalleListaReproduccionCancion
            builder.HasMany(o => o.DetalleListaReproduccionCanciones).
                WithOne(o=>o.ListaReproduccion).
                HasForeignKey(o => o.IdListaReproduccion);
        }
    }
}