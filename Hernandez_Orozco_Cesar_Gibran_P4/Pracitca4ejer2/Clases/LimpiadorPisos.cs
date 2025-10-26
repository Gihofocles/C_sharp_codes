using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class LimpiadorPisos : Limpieza
    {
        protected string tipodepiso;
        public string TipoDePiso
        {
            get { return tipodepiso; }
            set { tipodepiso = value; }
        }
        public LimpiadorPisos()
        {
        }
        /// <summary>
        /// Constructor por parametros de Limpiador pisos
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="marca"></param>
        /// <param name="nombrecomercial"></param>
        /// <param name="peso"></param>
        /// <param name="precio"></param>
        /// <param name="componente"></param>
        /// <param name="tipodepiso"></param>
        public LimpiadorPisos(double identificador, string marca, string nombrecomercial, double peso, double precio, string componente, string tipodepiso)
        {
            this.Identificador = identificador;
            this.Marca = marca;
            this.NombreComercial = nombrecomercial;
            this.Peso = peso;
            this.Precio = precio;
            this.Componente = componente;
            this.TipoDePiso = tipodepiso;
        }
        /// <summary>
        /// Metodo imprimir limpiador pisos
        /// </summary>
        public void Imprimirlimpiadordepisos()
        {
            Imprimirlimpieza();
            Console.WriteLine("Tipo de piso: " + TipoDePiso);
        }
    }

}
