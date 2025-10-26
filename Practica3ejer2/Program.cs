/**
 * Practica3ejer2.cs
 * Autor: Hernandez Orozco Cesar Gibran
 * Fecha: 2022/10/09
 * Boleta: 2022640421
 * No. Practica: 3
 * No. Programa: 2
 * */

using Practica3ejer2.Clases;
using System.Security.Cryptography.X509Certificates;

namespace Practica3ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dia: ");
            string dia = Console.ReadLine();
            Console.WriteLine("Mes: ");
            string mes = Console.ReadLine();
            Console.WriteLine("Año: ");
            string ano = Console.ReadLine();
            Console.WriteLine("Hora: ");
            string hora = Console.ReadLine();
            Console.WriteLine("Minuto: ");
            string minutos = Console.ReadLine();
            Console.WriteLine("Segundo: ");
            string segundos = Console.ReadLine();

            Fecha hoy = new Fecha(dia, mes, ano, hora, minutos, segundos);
            hoy.imprimir();
        }
    }
}