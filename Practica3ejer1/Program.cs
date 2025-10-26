/**
 * Practica3ejer1.cs
 * Autor: Hernandez Orozco Cesar Gibran
 * Fecha: 2022/10/09
 * Boleta: 2022640421
 * No. Practica: 3
 * No. Programa: 1
 * */
using Practica3ejer1.Clases;

namespace Practica3ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int opt = 0;
                while (opt < 1 || opt > 3)
                {
                    Console.WriteLine("Elige una opcion: ");
                    Console.WriteLine("1.Sumar dos matrices\n2.Multiplicar dos matrices\n3.Trasponer una matriz");
                    int.TryParse(Console.ReadLine(), out opt);
                    if (opt < 1 || opt > 3)
                    {
                        Console.WriteLine("Opcion no es valida intente de nuevo");
                        Console.ReadKey();
                    }
                    Console.Clear();

                }
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Suma");
                        Matrix Suma = new Matrix("sum");
                        Suma.imprimir();
                        break;
                    case 2:
                        Console.WriteLine("Multiplicacion");
                        Matrix Multiplicacion = new Matrix("mult");
                        Multiplicacion.imprimir();
                        break;
                    case 3:
                        Console.WriteLine("Traspuesta: ");
                        Matrix Traspuesta = new Matrix("tras");
                        Traspuesta.imprimir();
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        break;
                }
                Console.WriteLine("Presione una tecla para regresar al menu");
                Console.ReadKey();
            }
        }
    }
}