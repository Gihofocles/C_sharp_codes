using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    internal class Catalogo
    {
        
        public string titulo;
        public int ano;
        public string clasificacion;
        public string director;
        public string actoresprincipales;
        public string descripcion;
        List<Pelicula> CatalogoPeliculas = new List<Pelicula>();


        public Catalogo()
        {
            
        }

        public void registrarpeliculas()
        {
            titulo = "Pulp fiction";
            ano = 1994;
            clasificacion = "R";
            director = "Quentin Tarantino";
            actoresprincipales = "Samuel L jackson, Uma Thurman, John Travolta, Bruce Willis";
            descripcion = "Dos gansters buscan un maletin y se toparan con obstaculos imprevistos, un boxeador fracasado intenta escapar de la mafia y la esposa de un capo de la mafia pasa una noche intensa con uno de sus gansters";

            CatalogoPeliculas.Add(new Pelicula(titulo, ano, clasificacion, director, actoresprincipales, descripcion));

            titulo = "Petroleo sangriento";
            ano = 2007;
            clasificacion = "B-15";
            director = "Paul thomas anderson";
            actoresprincipales = "Daniel day-lewis";
            descripcion = "La vida de un magnate de petroleo desde sus humildes inicios hasta que la avaricia lo corrompe";

            CatalogoPeliculas.Add( new Pelicula(titulo, ano, clasificacion, director, actoresprincipales, descripcion));

            titulo = "Forrest Gump";
            ano = 1994;
            clasificacion = "A";
            director = "Steven Spielberg";
            actoresprincipales = "Tom Hanks";
            descripcion = "La vida de Forrest gump mientras pasa por diferentes eventos mundiales y cambios en estados unidos";

            CatalogoPeliculas.Add( new Pelicula(titulo, ano, clasificacion, director, actoresprincipales, descripcion));
        }
        public void imprimir()
        {
            Console.WriteLine("Catalogo: ");
            StringBuilder sb = new StringBuilder();
            foreach (var Pelicula in CatalogoPeliculas)
            {

                Console.WriteLine("---------------------");
                sb.AppendLine(Pelicula.ToString());
                Console.WriteLine(sb.ToString());
                Console.WriteLine("---------------------\n"); 

            }

        }
    }
}
