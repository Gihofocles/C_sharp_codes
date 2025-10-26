/**
 * practica2programa2.cs
 * Autor: Hernandez Orozco Cesar Gibran
 * Fecha: 2022/09/21
 * Boleta: 2022640421
 * No. Practica: 2
 * No. Programa: 1
 * */

using Practica2programa1.Clases;

namespace Practica2programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> ListaPersonas = new List<Persona>();
            for (int i = 0; i < 3; i++)
            {
                string Nombre;
                int Edad;
                double Estatura;
                double Telefono;
                Console.WriteLine("Persona " + (i + 1) + ": ");
                Console.WriteLine("Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Estatura: ");
                Estatura = double.Parse(Console.ReadLine());
                Console.WriteLine("Telefono: ");
                Telefono = double.Parse(Console.ReadLine());
                ListaPersonas.Add(new Persona(Nombre, Edad, Estatura, Telefono));
            }
            Console.Clear();
            foreach (var Persona in ListaPersonas)
            {
                Console.WriteLine("Persona " + (ListaPersonas.IndexOf(Persona) + 1));
                Console.WriteLine(Persona.ToString());
            }
        }
    }
}