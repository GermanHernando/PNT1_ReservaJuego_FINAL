
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public  class Juego
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJuego { get; set; }
        [Required(ErrorMessage = "Por favor, introduce un Nombre"), MaxLength(12)]
        public string NombreJuego { get; set; }
        [Range(18, 70,ErrorMessage ="Debe ser mayor a 18 años")]  
        public int EdadJugadores { get; set; }
        [Range(2, 4, ErrorMessage = "Debe ingresar una cantidad de jugadores válida entre 2 y 4 personas")]
        public int CantJugadoresMin { get; set; }
        [Range(6, 8, ErrorMessage = "Debe ingresar una cantidad de jugadores válida entre 6 y 8 personas")]
        public int CantJugadoresMax { get; set; }
        [EnumDataType(typeof(Categoria))]
        [Required(ErrorMessage = "Por favor, seleccione una Categoría")]//No aparece en pantalla
        public Categoria Categoria { get; set; }
        [EnumDataType(typeof(Dificultad))]
        [Required(ErrorMessage = "Por favor, seleccione una Dificultad")] //No aparece en pantalla
        public Dificultad Dificultad { get; set; }
        public int CantFichas { get; set; }
      
    }
}
