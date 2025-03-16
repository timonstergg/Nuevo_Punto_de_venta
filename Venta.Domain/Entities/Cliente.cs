using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Entities
{
    public class Cliente:Persona
    {
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
