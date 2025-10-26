using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Pelicula
    {
        private string titulo;
        private int ano;
        private string clasificacion;
        private string director;
        private string actoresprincipales;
        private string descripcion;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public string ActoresPrincipales
        {
            get { return actoresprincipales; }
            set { actoresprincipales = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public Pelicula(string titulo, int ano, string clasificacion, string director, string actoresprincipales, string descripcion)
        {
            Titulo = titulo;
            Ano = ano;
            Clasificacion = clasificacion;
            Director = director;
            ActoresPrincipales = actoresprincipales;
            Descripcion = descripcion;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("titulo: ");
            sb.AppendLine(Titulo.ToString());
            sb.Append("Año: ");
            sb.AppendLine(Ano.ToString());
            sb.Append("Clasificacion: ");
            sb.AppendLine(Clasificacion.ToString());
            sb.Append("Director: ");
            sb.AppendLine(director.ToString());
            sb.Append("Actores principales: ");
            sb.AppendLine(actoresprincipales.ToString());
            sb.Append("Descripcion: " );
            sb.AppendLine(Descripcion.ToString());
            return sb.ToString();
        }
    }
}
