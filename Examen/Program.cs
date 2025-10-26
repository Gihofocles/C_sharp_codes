
using System.ComponentModel;

using Examen.Clases;
namespace Examen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.registrarpeliculas();
            catalogo.imprimir();

          
            
        }
    }
}