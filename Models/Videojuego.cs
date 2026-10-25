
using System.ComponentModel.DataAnnotations;

namespace GameZoneMVC.Models
{
    public class Videojuego
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del videojuego es obligatorio.")]
        [StringLength(60, ErrorMessage = "El nombre no puede superar los 60 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debes seleccionar un género.")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debes escribir la plataforma.")]
        public string Plataforma { get; set; } = string.Empty;

        [Range(0, 1000000, ErrorMessage = "El precio debe estar entre 0 y 1.000.000.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Debes escribir una descripción.")]
        [StringLength(250, ErrorMessage = "La descripción no puede superar los 250 caracteres.")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
