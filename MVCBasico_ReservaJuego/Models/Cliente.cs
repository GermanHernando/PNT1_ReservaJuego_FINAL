using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.ComponentModel;
using System.Drawing;

namespace MVCBasico_ReservaJuego.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Por favor, introduce un Nombre"), MaxLength(12)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor, introduce un Apellido"), MaxLength(12)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor, introduce un Número de Documento"), MaxLength(8)]
        public string? Dni { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Por favor, introduce un Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "El Email no es válido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Por favor, introduce un Número de Teléfono")]
        public int Telefono { get; set; }



        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }

        //Intentamos crear el atributo de solo lectura pero no nos permite por las variables diciendo que no puede 
        //hacer referencia al campo, metodo o propiedad no estático pero no podemos poner a las variables "Nombre" y "Apellido"
        //como estáticos porque siempre va a reemplazar el nombre y apellido anterior dentro del mismo espacio en memoria
        //Tendríamos varias reservas con el mismo nombre y apellido en todas
        //Estos fueron algunos de los intentos que probamos, qué nos recomienda hacer? 

        //Registros de Prueba y Error

        //public static string NombreApellido = Nombre + "" + Apellido;

        //public readonly string NombreApellido = (string)(Nombre + "" + Apellido);

        //public readonly string NombreApellido = Nombre & "" & Apellido;

        //public readonly string NombreApellido = string.Format(Nombre,Apellido);

        // public readonly string NombreApellido = (string)(Nombre & "" & Apellido);

        //public readonly string NombreApellido = (Nombre{get;} + "" + Apellido).ToString();

        //string name = string.Concat(Nombre, Apellido);

        //public readonly string NombreApellido = string.Concat(Nombre, Apellido);

        //public static ReadOnlyAttribute  NombreCompleto = Nombre + "" + Apellido;

        /* public readonly string nombreApellido(string? Nombre, string? Apellido)
         {
             return Nombre == null && Apellido == null ? string.Empty : Nombre + "" + Apellido;
         }*/




    }

}
