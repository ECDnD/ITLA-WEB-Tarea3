using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models
{
    public class Reportes
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public string? descripcion { get; set; }
        [Required]
        public float costo { get; set; }
        [Required]
        public int muertos { get; set; }
        [Required]
        public int heridos { get; set; }
        [Required]
        public int vehiculos { get; set; }
    }
}