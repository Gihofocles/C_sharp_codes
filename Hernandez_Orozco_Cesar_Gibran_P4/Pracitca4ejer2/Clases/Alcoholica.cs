using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Alcoholica : Bebidas
    {
        protected double porcentajealcohol;
        public double PorcentajeAlcohol
        {
            get { return porcentajealcohol; }
            set { porcentajealcohol = value; }
        }
        public Alcoholica()
        {
        }
        /// <summary>
        /// Constructor con parametros de alcoholica
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="mililitros"></param>
        /// <param name="porcentajealcohol"></param>
        public Alcoholica(double identificador, string marca, string nombrecomercial, double peso, double precio, double mililitros, double porcentajealcohol)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Mililitros = mililitros;
            this.PorcentajeAlcohol = porcentajealcohol;
        }
        /// <summary>
        /// Metodo para imprimir alcoholica
        /// </summary>
        public void Imprimiralcoholica()
        {
            ImprimirBebidas();
            Console.WriteLine("Porcentaje de Alcohol: " + PorcentajeAlcohol);
        }

    }
}
