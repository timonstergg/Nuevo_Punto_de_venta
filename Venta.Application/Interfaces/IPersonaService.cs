using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.Application.Interfaces
{
    public interface IPersonaService
    {
        void AgregarPersona(int id, string nombre);
        void MostrarPersonas();
        void ObtenerPersonaPorId(int id);
        void EliminarPersona(int id);
    }
}
