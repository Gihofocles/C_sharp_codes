using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Practica2programa2.Clases
{
    internal class Alumno
    {
        private string nombre;
        private string apellidopaterno;
        private string apellidomaterno;
        private int numerodeboleta;
        private string fechadenacimiento;
        private string carrera;
        private string grupo;
        private string correoelectronico;

        /// <summary>
        /// Nombre del alumno
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Apellido paterno del alumno
        /// </summary>
        public string ApellidoPaterno
        {
            get { return apellidopaterno; }
            set { apellidopaterno = value; }
        }
        /// <summary>
        /// Apellido Materno del alumno
        /// </summary>
        public string ApellidoMaterno
        {
            get { return apellidomaterno; }
            set { apellidomaterno = value; }
        }
        /// <summary>
        /// Numero de boleta del alumno
        /// </summary>
        public int NumeroDeBoleta
        {
            get { return numerodeboleta; }
            set { numerodeboleta = value; }
        }
        /// <summary>
        /// Fecha de nacimiento del alumno
        /// </summary>
        public string FechadeNacimiento
        {
            get { return fechadenacimiento;  }
            set { fechadenacimiento = value; }
        }
        /// <summary>
        /// Carrera del alumno
        /// </summary>
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        /// <summary>
        /// Grupo del alumno
        /// </summary>
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        /// <summary>
        /// Correo electronico del alumno
        /// </summary>
        public string CorreoElectronico
        {
            get { return correoelectronico; }
            set { correoelectronico = value; }
        }

        /// <summary>
        /// Constructor de alumno con parametros 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="ApellidoPaterno"></param>
        /// <param name="ApellidoMaterno"></param>
        /// <param name="NumeroDeBoleta"></param>
        /// <param name="FechadeNacimiento"></param>
        /// <param name="Carrera"></param>
        /// <param name="Grupo"></param>
        /// <param name="CorreoElectronico"></param>
        public Alumno (string Nombre, string ApellidoPaterno, string ApellidoMaterno, int NumeroDeBoleta, string FechadeNacimiento, string Carrera, string Grupo, string CorreoElectronico)
        {
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.NumeroDeBoleta = NumeroDeBoleta;
            this.Carrera = Carrera;
            this.FechadeNacimiento = FechadeNacimiento;
            this.Carrera = Carrera;
            this.Grupo = Grupo;
            this.CorreoElectronico = CorreoElectronico;


        }
        /// <summary>
        /// Constructor de alumno por defecto
        /// </summary>
        public Alumno()
        {

        }
        /// <summary>
        /// funcion que genera la lista de alumnos en string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(nombre.ToString());
            sb.Append("Apellido Paterno : ");
            sb.AppendLine(apellidopaterno.ToString());
            sb.Append("Apellido Materno : ");
            sb.AppendLine(apellidomaterno.ToString());
            sb.Append("Numero de boleta: ");
            sb.AppendLine(numerodeboleta.ToString());
            sb.Append("Fecha de nacimiento : ");
            sb.AppendLine(apellidopaterno.ToString());
            sb.Append("Carrera: ");
            sb.AppendLine(carrera.ToString());
            sb.Append("Grupo: ");
            sb.AppendLine(grupo.ToString());
            sb.Append("Correo electronico: ");
            sb.AppendLine(correoelectronico.ToString());
            return sb.ToString();
        }
    }
}
