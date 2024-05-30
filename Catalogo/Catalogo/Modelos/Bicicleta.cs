using System.ComponentModel.DataAnnotations;

namespace Catalogo.Modelos
{
    public class Bicicleta
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public string? Tipo { get; set; }
        public string? Estado { get; set; }

        public int? PersonaId { get; set; }
        
        virtual public ICollection<Persona?> Personas { get; set; } 

    }
}
