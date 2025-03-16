using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Entities
{
    public class Persona:BaseEntity
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
    }
}
