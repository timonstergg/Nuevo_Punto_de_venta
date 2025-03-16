using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Entities
{
    public class Venta
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new();
        public MetodoPago MetodoPago { get; set; }
        public EstadoVenta Estado { get; set; } = EstadoVenta.Pendiente;
    }

    public enum EstadoVenta
    {
        Pendiente,
        Pagado,
        Cancelado
    }

    public enum MetodoPago
    {
        Efectivo,
        Tarjeta,
        Transferencia
    }
}
