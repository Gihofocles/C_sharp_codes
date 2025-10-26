using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Bebes : Producto
    {
        protected int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public Bebes()
        {
        }
        /// <summary>
        /// Constructor por parametros de bebes
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        /// <param name="edad"></param>
        public Bebes(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos, int edad)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Edad = edad;
        }
        /// <summary>
        /// Metodo para imprimir bebes
        /// </summary>
        public void Imprimirbebes()
        {
            Imprimirproducto();
            Console.WriteLine("Edad: " + edad);
        }
    }
}
