using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentadeBebidas.Entities
{
    public class Productos
    {
        [Key]
        public int PkIdArticulo { get; set; }
        public string NombreProd { get; set; }
        public int Cantidad { get; set; }
        public string Sabor { get; set; }
        public int Tamaño { get; set; }
        public int Lote { get; set; }
        public int PrecioUnitario { get; set; }
    }
}
