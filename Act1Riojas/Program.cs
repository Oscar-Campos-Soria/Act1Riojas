using System;

namespace Act1Riojas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los nombres ingresados por el usuario
            List<string> nombres = new List<string>();

            Console.WriteLine("Por favor, ingrese 5 nombres:");

            // Pedir al usuario que ingrese 5 nombres uno por uno
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nombre {i + 1}: ");
                string nombre = Console.ReadLine();

                // Agregar el nombre a la lista
                nombres.Equals(nombre);
            }

            // Generar un número aleatorio
            Random rnd = new Random();
            int indiceSeleccionado = rnd.Next(1, 5);

            // Mostrar el nombre seleccionado al azar al usuario
            Console.WriteLine($"\nEl nombre seleccionado al azar es: { indiceSeleccionado}");
        }
    }

    internal class List<T>
    {
    }
}
