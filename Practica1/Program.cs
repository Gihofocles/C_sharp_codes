/**
 * practica1.cs
 * Autor: Hernandez Orozco Cesar Gibran
 * Fecha: 2022/09/2
 * Boleta: 2022640421
 * No. Practica: 1
 * */
using System;
using System.Diagnostics;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir == true) {
                Console.Clear();
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Media Aritmetica");
                Console.WriteLine("3. Desviacion Estandar");
                Console.WriteLine("4. Burbuja");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Escriba la opcion que desea");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out int menu);
                switch (menu)
                {
                    case 1:
                        Factorial();
                        break;
                    case 2:
                        MediaAritmetica();
                        break;
                    case 3:
                        DesviacionEstandar();
                        break;
                    case 4:
                        Burbuja();
                        break;
                    case 5:
                        salir = Salida();
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no es valida intenta de nuevo");
                        Console.ReadKey();
                        salir = true;
                        break;
                }
            }
        }
        /// <summary>
        /// Esta funcion solicita un numero al usuario y calcula su factorial
        /// </summary>
        static void Factorial()
        {
            double numero;
            double numerooriginal;
            double res = 1;
            Console.WriteLine("Ingrese un numero: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int num);
            numero = Convert.ToDouble(num);
            numerooriginal = numero;
            for (int i = 1; i < num; i++)
            {   
                res = numero * res;
                numero--;
            }
            Console.WriteLine("El factorial de: " + numerooriginal + " es: " + res);
            Console.ReadKey();
            Console.WriteLine("Presione cualquier tecla para continuar");

        }
        /// <summary>
        /// Esta funcion solicicita una cantidad de muestras definida por el usuario y obtiene su media aritmetica
        /// </summary>
        static void MediaAritmetica()
        {
            double res = 0;
            Console.WriteLine("Cuantas muestras se ingresaran: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int numeromuestras);
            double[] muestras = new double[numeromuestras];
            for (int i = 0; i < numeromuestras; i++)
            {
                Console.WriteLine("Muestra " + (i+1) + ": ");
                muestras[i]=double.Parse(Console.ReadLine());
                res = (res + muestras[i]);
            }
            Console.WriteLine("Muestras: " + String.Join(", ", muestras));
            Console.WriteLine("La media aritmetica es: " + (res / numeromuestras));
            Console.ReadKey();
        }
        /// <summary>
        /// Esta funcion solicita una cantidad de muestras definida por el usuario y calcula su desviacion estandar 
        /// </summary>
        static void DesviacionEstandar()
        {
            double media = 0;
            double desviacion = 0;
            Console.WriteLine("Cuantas muestras se ingresaran: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int numeromuestras);
            double[] muestras = new double[numeromuestras];
            for (int i = 0; i < numeromuestras; i++)
            {
                Console.WriteLine("Muestra " + (i + 1) + ": ");
                muestras[i] = double.Parse(Console.ReadLine());
                media = (media + muestras[i]);
            }
            media = media / numeromuestras;
            for (int i = 0; i < numeromuestras; i++)
            {
                desviacion = desviacion + Math.Pow((media - muestras[i]),2);  
            }
            desviacion = Math.Sqrt(desviacion / numeromuestras);
            Console.WriteLine("Muestras: " + String.Join(", ", muestras));
            Console.WriteLine("La desviacion estandar es: " + desviacion);
            Console.ReadKey();
        }
        /// <summary>
        /// Esta funcion genera un arreglo de n datos y los ordena de mayor a menor utilizando el algoritmo de ordenamiento burbuja
        /// </summary>
        static void Burbuja()
        {
            int aux;
            Console.WriteLine("Cuantos datos quieres generar: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int cantidaddatos);
            int []datos = new int [cantidaddatos];
            for (int i = 0; i < cantidaddatos; i++)
            {
                var rand = new Random();
                datos[i] = rand.Next(1,10001); ;
            }
            Console.WriteLine("Datos: " + String.Join(", ", datos));
            Console.WriteLine(cantidaddatos);
            for (int i = 0; i < cantidaddatos; i++)
            {
                for (int g = 0; g < cantidaddatos; g++)
                {
                    if (datos[g] < datos[i])
                    {
                        aux = datos[g];
                        datos[g] = datos[i];
                        datos[i] = aux;
                    }
                }
            }
            Console.WriteLine("Datos ordenados: " + String.Join(", ", datos));
            Console.ReadKey();
        }
        /// <summary>
        /// Esta funcion sale del programa
        /// </summary>
        /// <returns>True o False</returns>
        static bool Salida()
        {
            Console.WriteLine ("adios vuelva pronto");
            Console.ReadKey();
            return false;
        }
    }
}

