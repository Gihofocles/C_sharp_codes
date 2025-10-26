using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica3ejer1.Clases
{
    internal class Matrix
    {
        private int filas;
        private int columnas;
        private double elemento;

        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }
        public int Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }
        public double Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
        public double[,] matriz;

        /// <summary>
        /// constructor de matriz 
        /// </summary>
        /// <param name="Filas"></param>
        /// <param name="Columnas"></param>
        public Matrix(int Filas, int Columnas)
        {
            this.Filas = Filas;
            this.Columnas = Columnas;
            //double[][] matriz;
            matriz = new double[filas, columnas];


            for (int i = 0; i < Filas; i++)
            {
                for(int g=0; g<Columnas; g++)
                {                    
                        Console.WriteLine("Elemento en la fila: " + (i + 1) + " Columna: " + (g + 1));
                        //Elemento = double.Parse(Console.ReadLine());
                        double.TryParse(Console.ReadLine(), out elemento);
                        matriz[i, g] = elemento;
                }
            }
        }
        /// <summary>
        /// constructor de matriz para una operacion
        /// </summary>
        /// <param name="opt"></param>
        public Matrix(string opt)
        {
            if ((opt.ToUpper() == "SUMAR") || (opt.ToUpper() == "S") || (opt.ToUpper() == "+") || (opt.ToUpper() == "SUM"))
            {
                int f;
                int c;
                Console.WriteLine("Filas de las matrices: ");
                int.TryParse(Console.ReadLine(), out f);
                Console.WriteLine("Columnas de las matrices: ");
                int.TryParse(Console.ReadLine(), out c);
                Console.Clear();
                Console.WriteLine("Matriz a:");
                Matrix matriza = new Matrix(f, c);
                Console.Clear();
                Console.WriteLine("Matriz b:");
                Matrix matrizb = new Matrix(f, c);
                Console.Clear();

                if (matriza.Filas == matrizb.Filas)
                {
                    if (matriza.Columnas == matrizb.Columnas)
                    {
                        Filas = matriza.Filas;
                        Columnas = matriza.Columnas;
                        matriz = new double[Filas, Columnas];
                        for (int i = 0; i < filas; i++)
                        {
                            for (int g = 0; g < columnas; g++)
                            {
                                matriz[i, g] = ((matriza.matriz[i, g]) + (matrizb.matriz[i, g]));
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("");
                        matriza.imprimir();
                        Console.WriteLine("+");
                        matrizb.imprimir();
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No es posible realizar la suma, dimensiones de matriz diferentes");
                }
            }

            if ((opt.ToUpper() == "MULTIPLICACION") || (opt.ToUpper() == "M") || (opt.ToUpper() == "*") || (opt.ToUpper() == "MULT"))
            {
                int f;
                int c;
                Console.WriteLine("Filas de la matriz a: ");
                int.TryParse(Console.ReadLine(), out f);
                Console.WriteLine("Columnas de la matriz a: ");
                int.TryParse(Console.ReadLine(), out c);
                Console.Clear();
                Matrix matriza = new Matrix(f, c);
                Console.Clear();
                Console.WriteLine("Filas de la matriz b: ");
                int.TryParse(Console.ReadLine(), out f);
                Console.WriteLine("Columnas de la matriz b: ");
                int.TryParse(Console.ReadLine(), out c);
                Console.Clear();
                Matrix matrizb = new Matrix(f, c);
                Console.Clear();

                if (matriza.Columnas == matrizb.Filas)
                {
                    Filas = matriza.Filas;
                    Columnas = matrizb.Columnas;
                    matriz = new double[Filas, Columnas];

                    double a = 0;
                    int f1 = matriza.Filas;
                    int f2 = matrizb.Filas;
                    int c1 = matriza.Columnas;
                    int c2 = matrizb.Columnas;
                    for (int i = 0; i < f1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            for (int g = 0; g < f2; g++)
                            {
                                Console.Write("  " + g + "   ");
                                a = (a + (matriza.matriz[i, g] * matrizb.matriz[g, j]));
                            }
                            matriz[i, j] = a;
                            a = 0;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("");
                    matriza.imprimir();
                    Console.WriteLine("*");
                    matrizb.imprimir();
                    Console.WriteLine("");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No es posible realizar la multiplicacion, las dimensiones no son correctas");
                }
            }

            if ((opt.ToUpper() == "TRASPUESTA") || (opt.ToUpper() == "T") || (opt.ToUpper() == "TRAS"))
            {
                int f;
                int c;
                Console.WriteLine("Filas de la matriz: ");
                int.TryParse(Console.ReadLine(), out f);
                Console.WriteLine("Columnas de la matriz: ");
                int.TryParse(Console.ReadLine(), out c);
                Console.Clear();
                Matrix matriza = new Matrix(f, c);
                Console.Clear();
                Filas = matriza.Columnas;
                Columnas = matriza.Filas;
                matriz = new double[Filas, Columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int g = 0; g < columnas; g++)
                    {
                        matriz[i, g] = matriza.matriz[g, i];
                    }
                }
                Console.Clear();
                matriza.imprimir();
                Console.WriteLine("");
                Console.WriteLine("traspuesta: ");
                Console.WriteLine("");                
            }


        }
        /// <summary>
        /// Funcion para imprimir la matriz 
        /// </summary>
        public void imprimir()
        { 
            for(int i = 0; i < filas; i++)
            {
                Console.Write("|");
                for(int g = 0; g < columnas; g++)
                {
                    //Console.Write(String.Join(",", matriz[i,g]));
                    Console.Write(matriz[i, g] + "\t|");
                }
                Console.WriteLine();
            }
        }
    }
}

