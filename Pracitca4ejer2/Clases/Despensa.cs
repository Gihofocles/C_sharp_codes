using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Despensa : Producto
    {
        protected double gramos;
        public double Gramos
        {
            get { return gramos; }
            set { gramos = value; }
        }
        public Despensa()
        {
        }
        /// <summary>
        /// Constructor por parametros de despensa
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        public Despensa(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.gramos = gramos;
        }
        /// <summary>
        /// metodo para imprimir persona
        /// </summary>
        public void Imprimirdespensa()
        {
            Imprimirproducto();
            Console.WriteLine("Gramos: " + Gramos);
        }

    }
}
