using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentadeBebidas.Entities
{
    public class Vendedor
    {
        [Key]
        public int IdVendedor { get; set; }

        public string NombreVend { get; set; }
        public string ApellidoVend { get; set; }
        public string CorreoVend { get; set; }
        public string ContraseñaVend { get; set; }
    }
}
