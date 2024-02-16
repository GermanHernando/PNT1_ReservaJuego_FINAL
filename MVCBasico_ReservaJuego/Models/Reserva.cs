using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva { get; set; }
        [ForeignKey("IdJuego")] //Antes IdJuego
        public int IdJuego { get; set; } //No nos deja con la clase Juego, lo cambiamos a int
        //[Display(Name = "Nombre de Juego")]
        public virtual Juego? Juego { get; set; }

        [ForeignKey("IdCliente")] //Antes IdCliente
        public int IdCliente { get; set; } //No nos deja con la clase Cliente, lo cambiamos a int
        //[Display(Name = "Nombre de Cliente")]
        public virtual Cliente? Cliente { get; set;}

       /* public int AuthorID { get; set; }       // sería luego la FK para relacionar en la BDD

        [Display(Name = "Autor")]
        public virtual Author? Author { get; set; } // Es para de la referencia FK, para luego mostrar
                                                    // en las vistas, los datos de la instancia de autor
       */


    }

}
