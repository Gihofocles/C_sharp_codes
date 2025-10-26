using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica4ejer1.Clases
{
    internal class ComputadoraPortatil : Computadora
    {
        private double duracionbateria;
        public double Duracionbateria
        {
            get { return duracionbateria; }
            set { duracionbateria = value; }
        }

        public ComputadoraPortatil(int ram, string procesador, string marca, double duracionbateria)
        {
            this.Ram = ram;
            this.Procesador = procesador;
            this.Marca = marca;
            this.Duracionbateria = duracionbateria;
        }
        /// <summary>
        /// Metodo para imprmir los elementos de una computadora protatil
        /// </summary>
        public void Imprimir()
        {
            ImprimirComputadora();
            Console.WriteLine("Duracion de la bateria: " + Duracionbateria + " horas");
        }
        /// <summary>
        /// Metodo para enviar un correo desde una computadora portatil
        /// </summary>
        public override void EnviarCorreo()
        {
            Console.WriteLine("Un correo ha sido enviado desde computadora portatil");
        }
    }
}
