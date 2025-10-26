using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Producto
    {
        protected double identificador;
        protected string marca;
        protected string nombrecomercial;
        protected double peso;
        protected double precio;

        public double Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string NombreComercial
        {
            get { return nombrecomercial; }
            set { nombrecomercial = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        /// <summary>
        /// Metodo imprimir producto
        /// </summary>
        public void Imprimirproducto()
        {
            Console.WriteLine("Identificador: " + identificador);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Nombre Comercial: " + nombrecomercial);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Precio: " + precio);
        }

    }
}
