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
        private T[] _entities; // Arreglo para almacenar las entidades
        private int _contador; // Cantidad de elementos en el arreglo

        public Repository()
        {
            _entities = new T[0]; // Inicializa el array vacío
            _contador = 0;
        }

        
        public void Agregar(T entity)
        {
            T[] nuevoArray = new T[_contador + 1]; 
            for (int i = 0; i < _contador; i++)
            {
                nuevoArray[i] = _entities[i]; 
            }

            nuevoArray[_contador] = entity; 
            _entities = nuevoArray; 
            _contador++;
        }

       
        public T ObtenerPorId(int id)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_entities[i].Id == id)
                {
                    return _entities[i]; // Retorna la entidad si encuentra el ID
                }
            }
            throw new KeyNotFoundException($"No se encontró una entidad con el ID {id}");
        }

       
        public IEnumerable<T> ObtenerTodas()
        {
            return _entities; 
        }


        // Eliminar una entidad sin usar Remove()
        public void Eliminar(int id)
        {
            int indice = -1;
            for (int i = 0; i < _contador; i++)
            {
                if (_entities[i].Id == id)
                {
                    indice = i;
                    break;
                }
            }

            if (indice == -1)
            {
                throw new KeyNotFoundException($"No se encontró una entidad con el ID {id}");
            }

            T[] nuevoArray = new T[_contador - 1];
            for (int i = 0, j = 0; i < _contador; i++)
            {
                if (i != indice) // Copia todos menos el que queremos eliminar
                {
                    nuevoArray[j] = _entities[i];
                    j++;
                }
            }

            _entities = nuevoArray;
            _contador--;
        }
    }
}

