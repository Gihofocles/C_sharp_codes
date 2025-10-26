using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    internal class Empleado
    {

       // public static double PI { get; set; }
        public int NoEmpleado { get; }
        public string Apellido1 {
            get { return Apellido1; }
            set { Apellido1 = value; }
        }
        public string Nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string Apellido2 {
            get { return Apellido2; }
            set { Apellido2 = value; }
        }
        public int Salario {
            get { return Salario; }
            set { Salario = value; }
        }

        public Empleado()
        {

        }
        public Empleado(int noEmpleado)
        {
            NoEmpleado = noEmpleado;
        }
        public Empleado(int noEmpleado, string nombre, string apellido1, string apellido2)
        {
            NoEmpleado = noEmpleado;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
        }
        public Empleado(int noEmpleado, string nombre, string apellido1)
        {
            NoEmpleado = noEmpleado;
            Nombre = nombre;
            Apellido1 = apellido1;

        }
        public string tostring()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("numero de empleado: ");
            sb.Append(NoEmpleado.ToString());
            return sb.ToString();
        }
        static Empleado()
        {
            PI = 3.14;
        }
        public void setPI(int valor)
        {
            PI=valor;
        }
    }
}
