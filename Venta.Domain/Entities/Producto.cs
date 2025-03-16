using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Entities
{
    public class Producto:BaseEntity
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
