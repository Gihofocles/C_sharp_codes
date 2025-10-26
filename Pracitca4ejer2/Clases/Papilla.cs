using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Papilla : Bebes
    {
        protected string sabor;
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }
        public Papilla()
        {
        }
        /// <summary>
        /// Constructor por parametros de Papilla
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        /// <param name="edad"></param>
        /// <param name="sabor"></param>
        public Papilla(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos, int edad, string sabor)
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
        /// Metodo imprimir papilla
        /// </summary>
        public void Imprimirpapilla()
        {
            Imprimirbebes();
            Console.WriteLine("Sabor: " + Sabor);
        }
    }
}
