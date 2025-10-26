/**
 * practica2programa2.cs
 * Autor: Hernandez Orozco Cesar Gibran
 * Fecha: 2022/09/21
 * Boleta: 2022640421
 * No. Practica: 2
 * no de programa: 2
 * */

using Practica2programa2.Clases;

namespace Practica2programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g;
            Console.WriteLine("Cuantos profesores vas a registrar");
            g = int.Parse(Console.ReadLine());
            List<Profesor> ListaProfesores = new List<Profesor>();  

            for (int i = 0; i < g; i++)
            {
                string Nombre;
                int Noempleado;
                Console.WriteLine("Profesor " + (i + 1) + ": ");
                Console.WriteLine("Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Numero de empleado: ");
                Noempleado = int.Parse(Console.ReadLine());
                ListaProfesores.Add(new Profesor(Nombre, Noempleado));
            }
            Console.Clear();
            foreach (var Profesor in ListaProfesores)
            {
                Console.WriteLine("Profesor " + (ListaProfesores.IndexOf(Profesor) + 1));
                Console.WriteLine(Profesor.ToString());
            }
        }
    }
}