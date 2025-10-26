using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4ejer1.Clases
{
    internal abstract class Computadora
    {
        protected int ram;
        protected string procesador;
        protected string marca;
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public string Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public Computadora()
        {

        }
        /// <summary>
        /// Metodo para imprimir los elementos de una computadora ram procesador marca
        /// </summary>
        public void ImprimirComputadora()
        {
            Console.WriteLine("Cantidad de ram: " + ram + "gb");
            Console.WriteLine("Procesador: " + procesador);
            Console.WriteLine("Marca: " + marca);
        }
        /// <summary>
        /// Metodo para enviar un correo
        /// </summary>
        public abstract void EnviarCorreo();
    }
}
