using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entity);
        T ObtenerPorId(int id);
        IEnumerable<T> ObtenerTodas();
        void Eliminar(int id);
    }
}
