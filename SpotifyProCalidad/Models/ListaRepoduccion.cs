using System.Collections.Generic;

namespace SpotifyProCalidad.Models
{
    public class ListaRepoduccion
    {
        public int Id { get; set; }

     
        public string Nombre { get; set; }
        
        
        public List<DetalleListaReproduccionCancion> DetalleListaReproduccionCanciones { get; set; }
    }
}