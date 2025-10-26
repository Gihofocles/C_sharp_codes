using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class CuidadoPersonal : Producto
    {
        protected double gramos;
        public double Gramos
        {
            get { return gramos; }
            set { gramos = value; }
        }
        public CuidadoPersonal()
        {
        }
        /// <summary>
        /// Constructor por parametros de cuidado personal
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        public CuidadoPersonal(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.gramos = gramos;
        }
        /// <summary>
        /// Metodo para imprimir cuidado personal
        /// </summary>
        public void Imprimircuidadopersonal()
        {
            Imprimirproducto();
            Console.WriteLine("Gramos: " + Gramos);
        }

    }
}

