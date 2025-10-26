using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Mascotas : Producto
    {
        protected string animal;
        public string Animal
        {
            get { return animal; }
            set { animal = value; }
        }
        public Mascotas()
        {
        }
        /// <summary>
        /// Constructor por parametros de Mascotas
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="animal"></param>
        public Mascotas(double identificador, string marca, string nombrecomercial, double peso, double precio, string animal)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Animal = animal;
        }
        /// <summary>
        /// Metodo imprimir mascota
        /// </summary>
        public void Imprimirmascota()
        {
            Imprimirproducto();
            Console.WriteLine("Para: " + animal);
        }
    }
}
