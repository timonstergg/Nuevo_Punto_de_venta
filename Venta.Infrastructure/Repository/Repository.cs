using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Venta.Domain.Entities;
using Venta.Domain.Interfaces;

namespace Venta.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T :  BaseEntity
    {
        private readonly List<T> _entities = new();

        public void Agregar(T entity)
        {
            _entities.Add(entity);
        }

        public T ObtenerPorId(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id)
                    ?? throw new KeyNotFoundException($"No se encontró una entidad con el ID {id}");
        }

        public IEnumerable<T> ObtenerTodas()
        {
            return _entities;
        }

        public void Eliminar(int id)
        {
            var entity = ObtenerPorId(id);
            _entities.Remove(entity);
        }

    }
}
