using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Azucaradas : Bebidas
    {
        protected double porcentajeazucar;
        public double PorcentajeAzucar
        {
            get { return porcentajeazucar; }
            set { porcentajeazucar = value; }
        }
        public Azucaradas()
        {
        }
        /// <summary>
        /// Constructor con parametros de azucaradas
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="mililitros"></param>
        /// <param name="porcentajeazucar"></param>
        public Azucaradas(double identificador, string marca, string nombrecomercial, double peso, double precio, double mililitros, double porcentajeazucar)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Mililitros = mililitros;
            this.PorcentajeAzucar = porcentajeazucar;
        }
        /// <summary>
        /// Metodo para imprimir azucaradas
        /// </summary>
        public void ImprimirAzucaradas()
        {
            ImprimirBebidas();
            Console.WriteLine("Porcentaje de azucar: " + PorcentajeAzucar);
        }
    }
}
