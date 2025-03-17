using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

using Venta.Application.Interfaces;
using Venta.Domain.Entities;
using Venta.Domain.Interfaces;

namespace Venta.Application.Services
{
    public class PersonaService: IPersonaService
    {
        private readonly IRepository<Persona> _repository; 

        public PersonaService(IRepository<Persona> repository) { 
        
            _repository = repository;
        }

        public void AgregarPersona(int id, string nombre) {

            var Persona = new Persona { Id = id, Nombre = nombre };
            _repository.Agregar(Persona);
            Console.WriteLine($"Persona agregada al inventario: {nombre}");

        }

        public void MostrarPersonas() {
            Console.Write("Lista de personas");
            foreach (var persona in _repository.ObtenerTodas()) {
                Console.WriteLine($"ID  {persona.Id} ,Nombre {persona.Nombre} ");          
            }       
        }

        public void ObtenerPersonaPorId(int id) {

            try
            {
                var persona = _repository.ObtenerPorId(id);
                Console.WriteLine($"Persona encontrada: {persona.Nombre}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        public void EliminarPersona(int id) {

            try
            {
              _repository.Eliminar(id);
                Console.WriteLine($"Persona eliminada con el ID {id}");
            }
            catch(Exception e) {

                Console.WriteLine($"Error : {e.Message}");
            }      
        }
    }
}
