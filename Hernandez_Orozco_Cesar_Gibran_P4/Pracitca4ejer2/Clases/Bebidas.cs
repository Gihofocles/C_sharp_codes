using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Bebidas : Producto
    {
        protected double mililitros;

        public double Mililitros
        {
            get { return mililitros; }
            set { mililitros = value; }
        }
        public Bebidas()
        {
        }
        /// <summary>
        /// Constructor por parametros de bebidas
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="mililitros"></param>
        public Bebidas(double identificador, string marca, string nombrecomercial, double peso, double precio, double mililitros)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Mililitros = mililitros;
        }
        /// <summary>
        /// metodo para imprimir bebidas
        /// </summary>
        public void ImprimirBebidas()
        {
            Imprimirproducto();
            Console.WriteLine("Mililitros: " + Mililitros);
        }
    }
}
