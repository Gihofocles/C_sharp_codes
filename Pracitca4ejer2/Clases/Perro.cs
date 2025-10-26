using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Perro : Mascotas
    {
        protected string raza;
        protected string tamano;
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public string Tamano
        {
            get { return tamano;}
            set { tamano = value; }
        }
        public Perro()
        {
        }
        /// <summary>
        /// Constructor por parametros de Perro
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="animal"></param>
        /// <param name="raza"></param>
        /// <param name="tamano"></param>
        public Perro(double identificador, string marca, string nombrecomercial, double peso, double precio, string animal, string raza, string tamano)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Animal = animal;
            this.Raza = raza;
            this.Tamano = tamano;
        }
        /// <summary>
        /// Metodo imprimir perro
        /// </summary>
        public void Imprimirperro()
        {
            Imprimirmascota();
            Console.WriteLine("Para: " + Raza);
            Console.WriteLine("Para: " + Tamano);
        }
    }
}
