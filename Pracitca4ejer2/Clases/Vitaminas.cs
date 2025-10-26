using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Vitaminas : CuidadoPersonal
    {
        protected string sabor;
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }
        public Vitaminas()
        {
        }
        /// <summary>
        /// Constructor por parametros de Vitaminas
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        /// <param name="sabor"></param>
        public Vitaminas(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos, string sabor)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Gramos = gramos;
            this.Sabor = sabor;
        }
        /// <summary>
        /// Metodo para imprimir vitaminas
        /// </summary>
        public void Imprimirvitaminas()
        {
            Imprimircuidadopersonal();
            Console.WriteLine("Sabor: " + Sabor);
        }
    }
}
