using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Limpieza : Producto
    {
        protected string componente;
        public string Componente
        {
            get { return componente; }
            set { componente = value; }
        }
        /// <summary>
        /// Constructor por parametros de Limpieza
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="componente"></param>
        public Limpieza(double identificador, string marca, string nombrecomercial, double peso, double precio, string componente)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Componente = componente;
        }
        public Limpieza()
        {
        }
        /// <summary>
        /// Metodo para imprimir limpieza
        /// </summary>
        public void Imprimirlimpieza()
        {
            Imprimirproducto();
            Console.WriteLine("Componente activo: " + componente);
        }
    }
}
