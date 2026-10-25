
using GameZoneMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameZoneMVC.Controllers
{
    public class VideojuegosController : Controller
    {
        private static List<Videojuego> videojuegos = new List<Videojuego>
        {
            new Videojuego
            {
                Id = 1,
                Nombre = "Minecraft",
                Genero = "Aventura",
                Plataforma = "PC",
                Precio = 90000,
                Descripcion = "Explora mundos, construye estructuras y sobrevive."
            },
            new Videojuego
            {
                Id = 2,
                Nombre = "Grand Theft Auto V",
                Genero = "Accion",
                Plataforma = "PC, PlayStation y Xbox",
                Precio = 120000,
                Descripcion = "Explora una ciudad abierta y completa misiones."
            },
            new Videojuego
            {
                Id = 3,
                Nombre = "FIFA 25",
                Genero = "Deportes",
                Plataforma = "PlayStation y Xbox",
                Precio = 150000,
                Descripcion = "Disfruta partidos de futbol y crea tu equipo."
            },
            new Videojuego
            {
                Id = 4,
                Nombre = "Fortnite",
                Genero = "Battle Royale",
                Plataforma = "PC y consolas",
                Precio = 0,
                Descripcion = "Compite contra otros jugadores y busca la victoria."
            }
        };

        public IActionResult Index()
        {
            return View(videojuegos);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Videojuego videojuego)
        {
            if (!ModelState.IsValid)
            {
                return View(videojuego);
            }

            videojuego.Id = videojuegos.Count == 0
                ? 1
                : videojuegos.Max(v => v.Id) + 1;

            videojuegos.Add(videojuego);

            return RedirectToAction(nameof(Index));
        }
    }
}
