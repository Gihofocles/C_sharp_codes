using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4ejer1.Clases
{
    internal class TelefonoInteligente : Computadora
    {
        private string resolucionpantalla;
        public string ResolucionPantalla
        {
            get { return resolucionpantalla; }
            set { resolucionpantalla = value; }
        }
        public TelefonoInteligente(int ram, string procesador, string marca, string resolucionpantalla)
        {
            this.Ram = ram;
            this.Procesador = procesador;
            this.Marca = marca;
            this.ResolucionPantalla = resolucionpantalla;
        }
        /// <summary>
        /// Metodo para imprimir los elementos de un telefono inteligente
        /// </summary>
        public void Imprimir()
        {
            ImprimirComputadora();
            Console.WriteLine("Resolucion de la pantalla: " + ResolucionPantalla);
        }
        /// <summary>
        /// metodo para enviar correos desde un telefono inteligente
        /// </summary>
        public override void EnviarCorreo()
        {
            Console.WriteLine("Un correo ha sido enviado desde Telefono Inteligente");
        }
    }
}
