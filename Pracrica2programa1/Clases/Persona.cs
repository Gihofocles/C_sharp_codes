using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practica2programa1.Clases
{
    internal class Persona
    {
        private string nombre;
        private int edad;
        private double estatura;
        private double telefono;

        /// <summary>
        /// Nomrbe de la persona
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Edad de la persona
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        /// <summary>
        /// Estatura de la persona
        /// </summary>
        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
        /// <summary>
        /// Telefono de la Persona
        /// </summary>
        public double Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /// <summary>
        /// Constructor de persona con parametros
        /// </summary>
        /// <param name="nombre1"></param>
        /// <param name="edad1"></param>
        /// <param name="estatura1"></param>
        /// <param name="telefono1"></param>
        public Persona(string nombre1, int edad1, double estatura1, double telefono1)
        {
            Nombre = nombre1;
            Edad = edad1;
            Estatura = estatura1;
            Telefono = telefono1;
        }
        /// <summary>
        /// Cosntructor de persona por defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Funcion para convertir los elementos de persona en string
        /// </summary>
        /// <returns>Los elementos contenidos en persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DateTime fecha = DateTime.Now;
            sb.Append("¡Hola!, mi nombre es " + nombre.ToString() + ", tengo " + edad.ToString() + " años, naci en " + (fecha.Year - edad).ToString() + ", mido " + estatura.ToString() + " metros, y mi numero de contacto es " + telefono.ToString() + " ¡Saludos!");

            return sb.ToString();
        }
    }
}
