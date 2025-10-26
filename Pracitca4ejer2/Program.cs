using Pracitca4ejer2.Clases;

namespace Pracitca4ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario._Alcoholicas.Add(new Alcoholica(1, "modelo", "especial", 5, 18, 355, 3));
            inventario._Alcoholicas.Add(new Alcoholica(2, "tecate", "especial", 5, 18, 355, 3));
            inventario._Alcoholicas.Add(new Alcoholica(3, "victoria", "especial", 5, 18, 355, 3));
            inventario._Azucaradas.Add(new Azucaradas(4, "Refresco", "Coca-Cola", 34, 17, 355, 49));
            inventario._Azucaradas.Add(new Azucaradas(5, "Refresco", "sprite", 323, 17, 355, 49));
            inventario._Azucaradas.Add(new Azucaradas(6, "Jugo", "jumex", 234, 16.5, 200, 20));
            inventario._Perro.Add(new Perro(7, "croqueta", "royal cannin", 1000, 250, "perro", "chihuaha", "chico"));
            inventario._Perro.Add(new Perro(8, "croqueta", "Proplan", 1000, 300, "perro", "frech puddle", "chico"));
            inventario._Perro.Add(new Perro(9, "croqueta", "beneful", 1000, 100, "perro", "golden", "grande"));
            inventario._Gato.Add(new Gato(10, "Croqueta", "catchow", 1500, 123, "gato", 5));
            inventario._Gato.Add(new Gato(11, "Croqueta", "catchow", 1500, 132, "gato", 10));
            inventario._Gato.Add(new Gato(12, "Croqueta", "catchow", 1500, 235, "gato", 20));
            inventario._Frijol.Add(new Frijol(13, "valle verde", "frijol negro", 500, 56, 500, "negros"));
            inventario._Frijol.Add(new Frijol(14, "valle verde", "frijol bayo", 500, 56, 500, "bayos"));
            inventario._Leche.Add(new Leche(15, "Lala", "leche lala", 32, 32, 1000, "deslactosada"));
            inventario._Leche.Add(new Leche(16, "Lala", "leche lala", 32, 32, 1000, "Entera"));
            inventario._Suero.Add(new Suero(17, "ensure", "ensure formula", 32, 543, 1000, 4, "vainilla"));
            inventario._Suero.Add(new Suero(18, "ensure", "ensure formula", 32, 543, 1000, 5, "chocolate"));
            inventario._Papilla.Add(new Papilla(19, "gerber", "gerber", 34, 31, 32, 5, "zanahoria"));
            inventario._Papilla.Add(new Papilla(20, "gerber", "gerber", 34, 31, 32, 5, "papa"));
            inventario._Crema.Add(new Crema(21, "pond", "crema pond", 54, 51, 53, "crema para cara"));
            inventario._Crema.Add(new Crema(22, "pond", "crema pond", 123, 123, 132, "crema para cara"));
            inventario._Vitaminas.Add(new Vitaminas(23, "redoxon", "redoxon vitaminas", 42, 234, 42, "naranja"));
            inventario._Vitaminas.Add(new Vitaminas(24, "redoxon", "redoxon vitaminas", 42, 234, 42, "uva"));
            inventario._LimpiadorPisos.Add(new LimpiadorPisos(25, "pinol", "pinol", 202, 35, "cloro", "todos"));
            inventario._LimpiadorPisos.Add(new LimpiadorPisos(26, "alex", "alex", 202, 35, "cloro", "madera"));
            inventario._DestapaCanos.Add(new DestapaCano(27, "drano", "drano destapacaños", 34, 234, "quimico destapador", "agresivo"));
            inventario._DestapaCanos.Add(new DestapaCano(28, "drano", "drano destapacaños", 34, 234, "quimico destapador", "leve"));
            
            inventario.Imprimirinventario();
        }
    }
}