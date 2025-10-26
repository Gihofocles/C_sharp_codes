using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitca4ejer2.Clases
{
    internal class Inventario
    {
        public List<Alcoholica> _Alcoholicas = new List<Alcoholica>();
        public List<Azucaradas> _Azucaradas = new List<Azucaradas>();
        public List<Perro> _Perro = new List<Perro>();
        public List<Gato> _Gato = new List<Gato>();
        public List<Frijol> _Frijol = new List<Frijol>();
        public List<Leche> _Leche = new List<Leche>();
        public List<Suero> _Suero = new List<Suero>();
        public List<Papilla> _Papilla = new List<Papilla>();
        public List<Crema> _Crema = new List<Crema>();
        public List<Vitaminas> _Vitaminas = new List<Vitaminas>();
        public List<LimpiadorPisos> _LimpiadorPisos = new List<LimpiadorPisos>();
        public List<DestapaCano> _DestapaCanos = new List<DestapaCano>();
        public Inventario()
        {

        }
        /// <summary>
        /// Metodo para imprimir el inventario
        /// </summary>
        public void Imprimirinventario()
        {
            Console.WriteLine("\n---------------------------");
            foreach (var Alcoholica in _Alcoholicas)
            {
                Console.WriteLine("\n---------------------------\n");
                Alcoholica.Imprimiralcoholica();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Azucaradas in _Azucaradas)
            {
                Console.WriteLine("\n---------------------------\n");
                Azucaradas.ImprimirAzucaradas();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Perro in _Perro)
            {
                Console.WriteLine("\n---------------------------\n");
                Perro.Imprimirperro();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Gato in _Gato)
            {
                Console.WriteLine("\n---------------------------\n");
                Gato.Imprimirgato();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Frijol in _Frijol)
            {
                Console.WriteLine("\n---------------------------\n");
                Frijol.Imprimirfrijol();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Leche in _Leche)
            {
                Console.WriteLine("\n---------------------------\n");
                Leche.Imprimirleche();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Suero in _Suero)
            {
                Console.WriteLine("\n---------------------------\n");
                Suero.Imprimirsuero();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Papilla in _Papilla)
            {
                Console.WriteLine("\n---------------------------\n");
                Papilla.Imprimirpapilla();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Crema in _Crema)
            {
                Console.WriteLine("\n---------------------------\n");
                Crema.imprimircrema();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var Vitaminas in _Vitaminas)
            {
                Console.WriteLine("\n---------------------------\n");
                Vitaminas.Imprimirvitaminas();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var LimpiadorPisos in _LimpiadorPisos)
            {
                Console.WriteLine("\n---------------------------\n");
                LimpiadorPisos.Imprimirlimpiadordepisos();
            }
            Console.WriteLine("\n---------------------------");
            foreach (var DestapaCano in _DestapaCanos)
            {
                Console.WriteLine("\n---------------------------\n");
                DestapaCano.Imprimirdestapacano();
            }
            Console.WriteLine("\n---------------------------\n");
        }
    }
}
