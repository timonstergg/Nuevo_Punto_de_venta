
using System;

using Venta.Application.Services;
using Venta.Domain.Entities;
using Venta.Infrastructure.Repository;

class Program  
{
    static void Main() 
    {
        var repositorio = new Repository<Persona>();
        var personaService = new PersonaService(repositorio);

        Console.WriteLine("Iniciando pruebas en consola...");

        personaService.AgregarPersona(1, "Juan");
        personaService.AgregarPersona(2, "María");

        // Mostrar personas almacenadas
        personaService.MostrarPersonas();

        //Buscar persona por ID
        Console.Write("Ingrese un ID para buscar: ");
        int idBusqueda = Convert.ToInt32(Console.ReadLine());
        personaService.ObtenerPersonaPorId(idBusqueda);

        // Eliminar persona por ID
        Console.Write("Ingrese un ID para eliminar: ");
        int idEliminar = Convert.ToInt32(Console.ReadLine());
        personaService.EliminarPersona(idEliminar);

        //Mostrar lista después de eliminar
        personaService.MostrarPersonas();

        Console.WriteLine("\nFin de la prueba.");

        //Mantener la consola abierta hasta que el usuario presione Enter
        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
}
