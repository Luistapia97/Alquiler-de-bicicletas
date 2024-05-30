using System.ComponentModel.DataAnnotations;

namespace Catalogo.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
      
        public virtual Persona? Persona { get; set; }
        public virtual Bicicleta? Bicicleta { get; set; } 


    }
}