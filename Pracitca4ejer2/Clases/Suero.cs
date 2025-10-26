using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Suero : Bebes
    {
        protected string sabor;
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }
        public Suero()
        {
        }
        /// <summary>
        /// Constructor por parametros de Suero
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        /// <param name="edad"></param>
        /// <param name="sabor"></param>
        public Suero(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos, int edad, string sabor)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Edad = edad;
            this.Sabor = sabor;
        }
        /// <summary>
        /// Metodo imprimir suero
        /// </summary>
        public void Imprimirsuero()
        {
            Imprimirbebes();
            Console.WriteLine("Sabor: " + Sabor);
        }
    }
}
