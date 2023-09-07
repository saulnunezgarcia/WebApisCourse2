using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.DTO
{   //Aqui solo se van a mostrar las propiedades que se van a querer mostrar cuando se expongan los datos 
    public class VillaCreateDto
    {
        // Se pueden especificar propiedades necesarias para los datos, como el tipo de formato que deben de tener por ejemplo 
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(30)]
        public string Nombre { get; set; } //Se pueden agregar mas propiedades al modelo 
        public string Detalle { get; set; }
        [Required(ErrorMessage = "La tarifa es requerida")]
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }

    }
}
