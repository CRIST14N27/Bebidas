using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentadeBebidas.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int? FkRol { get; set; } //? este campo no es obligatorio

        public Rol Roles { get; set; }

    }
}
