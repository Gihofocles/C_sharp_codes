using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class DestapaCano : Limpieza
    {
        protected string grado;
        public string Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        /// <summary>
        /// Constructor por parametros de Destapa cano
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="componente"></param>
        /// <param name="grado"></param>
        public DestapaCano(double identificador, string marca, string nombrecomercial, double peso, double precio, string componente, string grado)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Componente = componente;
            this.Grado = grado;
        }
        public DestapaCano()
        {
        }
        /// <summary>
        /// Metodo para imprimir destapacano
        /// </summary>
        public void Imprimirdestapacano()
        {
            Imprimirlimpieza();
            Console.WriteLine("Grado de limpieza: " + Grado);
        }
    }
}
