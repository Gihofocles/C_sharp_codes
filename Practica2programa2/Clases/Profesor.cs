using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2programa2.Clases
{
    internal class Profesor
    {
        private string nombre;
        private int noempleado;
        private int g;
        List<Alumno> ListaAlumnos = new List<Alumno>();
        /// <summary>
        /// Nombre del profesor
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Numero de empleado del profesor
        /// </summary>
        public int Noempleado
        {
            get { return noempleado; }
            set { noempleado = value; } 
        }

        /// <summary>
        /// Constructor de profesor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="noempleado"></param>
        public Profesor(string nombre, int noempleado)
        {
            Nombre = nombre;
            Noempleado = noempleado;
            Console.WriteLine("Cuantos alumnos vas a registrar: ");
            g = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < g; i++)
            {
                string _Nombre;
                string apellidopaterno;
                string apellidomaterno;
                int numerodeboleta;
                string fechadenacimiento;
                string carrera;
                string grupo;
                string correoelectronico;
                Console.WriteLine("Alumno " + (i + 1) + ": ");
                Console.WriteLine("Nombre: ");
                _Nombre = Console.ReadLine();
                Console.WriteLine("Apellido Paterno: ");
                apellidopaterno = Console.ReadLine();
                Console.WriteLine("Apellido Materno: ");
                apellidomaterno = Console.ReadLine();
                Console.WriteLine("Numero de boleta: ");
                numerodeboleta = int.Parse(Console.ReadLine());
                Console.WriteLine("Fecha de nacimiento: ");
                fechadenacimiento = Console.ReadLine();
                Console.WriteLine("Carrera: ");
                carrera = Console.ReadLine();
                Console.WriteLine("Grupo: ");
                grupo = Console.ReadLine();
                Console.WriteLine("Correo electronico: ");
                correoelectronico = Console.ReadLine();
                ListaAlumnos.Add(new Alumno(_Nombre,apellidopaterno, apellidomaterno, numerodeboleta, fechadenacimiento, carrera, grupo, correoelectronico ));
            }

        }
        /// <summary>
        /// Constructor de profesor por defecto
        /// </summary>
        public Profesor()
        {
            Console.WriteLine("Cuantos alumnos vas a registrar: ");
            g = int.Parse(Console.ReadLine());

            for (int i = 0; i < g; i++)
            {
                string _Nombre;
                string apellidopaterno;
                string apellidomaterno;
                int numerodeboleta;
                string fechadenacimiento;
                string carrera;
                string grupo;
                string correoelectronico;
                Console.WriteLine("Alumno " + (i + 1) + ": ");
                Console.WriteLine("Nombre: ");
                _Nombre = Console.ReadLine();
                Console.WriteLine("Apellido Paterno: ");
                apellidopaterno = Console.ReadLine();
                Console.WriteLine("Apellido Materno: ");
                apellidomaterno = Console.ReadLine();
                Console.WriteLine("Numero de boleta: ");
                numerodeboleta = int.Parse(Console.ReadLine());
                Console.WriteLine("Fecha de nacimiento: ");
                fechadenacimiento = Console.ReadLine();
                Console.WriteLine("Carrera: ");
                carrera = Console.ReadLine();
                Console.WriteLine("Grupo: ");
                grupo = Console.ReadLine();
                Console.WriteLine("Correo electronico: ");
                correoelectronico = Console.ReadLine();
                ListaAlumnos.Add(new Alumno(_Nombre, apellidopaterno, apellidomaterno, numerodeboleta, fechadenacimiento, carrera, grupo, correoelectronico));
            }
        }
        /// <summary>
        /// funcion que genera la lista de profesores con sus alumnos en string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(nombre.ToString());
            sb.Append("Numero de empleado: ");
            sb.AppendLine(noempleado.ToString());
            sb.AppendLine("-------------------------------");
            sb.AppendLine("Lista de alumnos inscritos");
            sb.AppendLine("-------------------------------");
            foreach (var Alumno in ListaAlumnos)
            {
                sb.AppendLine();
                sb.Append("Alumno " + (ListaAlumnos.IndexOf(Alumno) + 1).ToString() + ": ");
                sb.AppendLine();
                sb.AppendLine(Alumno.ToString());
            }
            sb.AppendLine("-------------------------------");
            sb.AppendLine("Total de alumnos inscritos: [" + (ListaAlumnos.Count).ToString() + "] ");
            sb.AppendLine("-------------------------------");
            return sb.ToString();
        }
    }
}
