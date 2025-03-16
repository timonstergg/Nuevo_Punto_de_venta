using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
