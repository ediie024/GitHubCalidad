using System.Collections.Generic;

namespace SpotifyProCalidad.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Musica { get; set; }
       
        public List<DetalleListaReproduccionCancion> DetalleListaReproduccionCanciones { get; set; }
    }
}