using System;

namespace A133590.Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 30");
            Console.WriteLine("Programa que presenta la sólo la hora, dada una fecha.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                Console.WriteLine("Presione cualquier tecla para continuar..");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Hora: {fecha.ToString("hh:mm tt")}");

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
