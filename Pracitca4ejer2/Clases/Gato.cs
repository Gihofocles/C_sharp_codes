using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Gato : Mascotas
    {
        protected int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public Gato()
        {
        }/// <summary>
         /// Constructor por parametros de Gato
         /// </summary>
         /// <param name="identificador"></param>
         /// <param name="marca"></param>
         /// <param name="nombrecomercial"></param>
         /// <param name="peso"></param>
         /// <param name="precio"></param>
         /// <param name="animal"></param>
         /// <param name="edad"></param>
        public Gato(double identificador, string marca, string nombrecomercial, double peso, double precio, string animal, int edad)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Animal = animal;
            this.Edad = edad;
        }
        /// <summary>
        /// Metodo para imprimir gato
        /// </summary>
        public void Imprimirgato()
        {
            Imprimirmascota();
            Console.WriteLine("Edad: " + Edad);
        }
        
    }
}
