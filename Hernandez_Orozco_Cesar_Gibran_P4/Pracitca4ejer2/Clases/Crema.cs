using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Crema : CuidadoPersonal
    {
        protected string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Crema()
        {
        }
        /// <summary>
        /// Constructor por parametros de crema
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="gramos"></param>
        /// <param name="tipo"></param>
        public Crema(double identificador, string marca, string nombrecomercial, double peso, double precio, double gramos, string tipo)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.gramos = gramos;
            this.tipo = tipo;
        }
        /// <summary>
        /// Metodo para imprimir crema
        /// </summary>
        public void imprimircrema()
        {
            Imprimircuidadopersonal();
            Console.WriteLine("Tipo: " + Tipo);
        }
    }
}

