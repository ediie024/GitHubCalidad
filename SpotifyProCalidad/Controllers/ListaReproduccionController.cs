using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SpotifyProCalidad.BD;
using SpotifyProCalidad.Models;

namespace SpotifyProCalidad.Controllers
{
    public class ListaReproduccionController : Controller
    {
        // GET
        
        SpotifyContext context = new SpotifyContext();
        SoundPlayer player = new SoundPlayer();

        public IActionResult Index()
        {
            var ListasDeReproducciones = context.ListaReproducciones.ToList();
            
           // return View(ListasDeReproducciones);
            return RedirectToAction("DetalleListaReproduccion");
        }

        public IActionResult DetalleListaReproduccion(int IdLista)
        {
            var DetalleListaReproduccion = context.DetalleListaReproduccionCanciones
                .Where(o => o.IdListaReproduccion == 3).ToList();
            var ListaCanciones = DetalleListaReproduccion.Select(o => o.IdCancion).ToList();
            var cancionesTotal = context.Canciones.ToList();
           
            Dictionary<int,Cancion> totalCanciones = new Dictionary<int, Cancion>();
            foreach (var itemCancion in cancionesTotal)
            {
                totalCanciones.Add(itemCancion.Id,itemCancion);
            }
            List<Cancion> CancionesDetalle = new List<Cancion>();
            foreach (var itemDetalle in ListaCanciones)
            {
                CancionesDetalle.Add(totalCanciones[itemDetalle]);
            }

            ViewBag.DetalleDeCanciones = CancionesDetalle;
            
            

            return View();
        }
    }
}
