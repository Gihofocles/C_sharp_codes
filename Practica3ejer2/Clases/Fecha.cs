using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica3ejer2.Clases
{
    internal class Fecha
    {
        private int segundos;
        private int minutos;
        private int hora;
        private int ano;
        private string mes;
        private int dia;

        public int Segundos
        {
            get { return segundos; }
            set
            { this.segundos = value; }
        }
        public int Minutos
        {
            get { return minutos; }
            set { this.minutos = value; }
        }
        public int Hora
        {
            get { return hora; }
            set { this.hora = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { this.ano = value; }
        }
        public string Mes
        {
            get { return mes; }
            set { this.mes = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { this.dia = value; }
        }
        /// <summary>
        /// Constructor de la clase Fecha
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="mes"></param>
        /// <param name="ano"></param>
        /// <param name="hora"></param>
        /// <param name="minutos"></param>
        /// <param name="segundos"></param>
        public Fecha(string dia, string mes, string ano, string hora, string minutos, string segundos)
        {
            bool a = false;
            while (a == false)
            {
                string m = mes.ToUpper();

                if (a == false)
                {
                    if (m == "ENERO" || m == "FEBRERO" || m == "MARZO" || m == "ABRRL" || m == "MAYO" || m == "JUNIO" || m == "JULIO" || m == "AGOSTO" || m == "SEPTIEMBRE" || m == "OCTUBRE" || m == "NOVIEMBRE" || m == "DICIEMBRE")
                    {
                        this.mes = mes;
                        a = true;
                    }
                }
                int me;
                if(int.TryParse(mes, out me) == true)
                {
                    me = int.Parse(mes);
                    if (me == 1)
                    {
                        this.mes = "ENERO";
                        a = true;
                    }
                    if (me == 2)
                    {
                        this.mes = "FEBRERO";
                        a = true;
                    }
                    if (me == 3)
                    {
                        this.mes = "MARZO";
                        a = true;
                    }
                    if (me == 4)
                    {
                        this.mes = "ABRIL";
                        a = true;
                    }
                    if (me == 5)
                    {
                        this.mes = "MAYO";
                        a = true;
                    }
                    if (me == 6)
                    {
                        this.mes = "JUNIO";
                        a = true;
                    }
                    if (me == 7)
                    {
                        this.mes = "JULIO";
                        a = true;
                    }
                    if (me == 8)
                    {
                        this.mes = "AGOSTO";
                        a = true;
                    }
                    if (me == 9)
                    {
                        this.mes = "SEPTIEMBRE";
                        a = true;
                    }
                    if (me == 10)
                    {
                        this.mes = "OCTUBRE";
                        a = true;
                    }
                    if (me == 11)
                    {
                        this.mes = "NOVIEMBRE";
                        a = true;
                    }
                    if (me == 12)
                    {
                        this.mes = "DICIEMBRE";
                        a = true;
                    }
                    else if (me > 12)
                    {
                        Console.WriteLine(me);
                        Console.WriteLine("Opcion no valida intente de nuevo");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Mes: ");
                        mes = Console.ReadLine();
                        a = true;
                    }  
                }
            }

            a = false;
            while (a == false)
            {
                a = int.TryParse(ano, out this.ano);
                if (a == false)
                {
                    Console.WriteLine("Opcion no valida intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Año: ");
                    ano = Console.ReadLine();
                }
                else
                {
                    this.ano = int.Parse(ano);
                    if ((this.ano >= 0) && (this.ano <= 2022))
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                        ano = "";
                    }
                }
            }

            a = false;
            while (a == false)
            {
               
                a = int.TryParse(dia, out this.dia);
                if (a == false)
                {
                    Console.WriteLine("Opcion no valida intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dia: ");
                    dia = Console.ReadLine();
                }
                else
                {
                    this.Dia = int.Parse(dia);
                    if ((this.mes == "ENERO") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "MARZO") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "ABRIL") && (this.Dia <= 30) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "MAYO") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "JUNIO") && (this.Dia <= 30) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "JULIO") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "AGOSTO") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "SEPTIEMBRE") && (this.Dia <= 30) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "OCTUBRE") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "NOVIEMBRE") && (this.Dia <= 30) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "DICIEMBRE") && (this.Dia <= 31) && (this.Dia > 0))
                    {
                        this.Dia = int.Parse(dia);
                        a = true;
                    }
                    else if ((this.mes == "FEBRERO") && (this.Dia <= 29) && (this.Dia > 0))
                    {                        
                        if ((this.ano%4 == 0))
                        {                            
                            if (this.ano%100 != 0)
                            {
                                if (this.dia <= 29)
                                {
                                    this.Dia = int.Parse(dia);
                                    a = true;
                                }
                            }
                            else if (this.ano % 400 == 0)
                            {
                                if (this.dia <= 29)
                                {
                                    this.Dia = int.Parse(dia);
                                    a = true;
                                }
                            }                            
                            else
                            {
                                if (this.dia <= 28)
                                {
                                    this.Dia = int.Parse(dia);
                                    a = true;
                                }
                                else
                                {
                                    a = false;
                                    dia = "";
                                }                                
                            }
                        }
                        else
                        {
                            if(this.dia <= 28)
                            {
                                this.Dia = int.Parse(dia);
                                a = true;
                            }
                            else
                            {
                                a = false;
                                dia = "";
                            }
                        }
                        
                    }
                    else
                    {
                        a = false;
                        dia = "";
                    }


                }
            }

            a = false;
            while (a == false)
            {
                a = int.TryParse(hora, out this.hora);
                if (a == false)
                {
                    Console.WriteLine("Opcion no valida intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dia: ");
                    hora = Console.ReadLine();
                }
                else
                {
                    this.Hora = int.Parse(hora);
                    if ((this.Hora >= 0) && (this.Hora < 61))
                    {
                        this.Hora = int.Parse(hora);
                        a = true;
                    }
                    else
                    {
                        a = false;
                        hora = " ";
                    }
                }

            }
            a = false;
            while( a == false)
            {
                a = int.TryParse(minutos, out this.minutos);
                if(a == false)
                {
                    Console.WriteLine("Opcion no valida intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Minuto: ");
                    minutos = Console.ReadLine();
                }
                else
                {
                    this.Minutos = int.Parse(minutos);
                    if ((this.Minutos >= 0) && (this.Minutos < 61))
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                        minutos = "";
                    }
                }
            }

            a = false;
            while (a == false)
            {
                a = int.TryParse(segundos, out this.segundos);
                if (a == false)
                {
                    Console.WriteLine("Opcion no valida intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Segundos: ");
                    segundos = Console.ReadLine();
                }
                else
                {
                    this.Segundos = int.Parse(segundos);
                    if ((this.Segundos >= 0) && (this.Segundos < 61))
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                        segundos = "";
                    }
                }
            }

           
        }
        /// <summary>
        /// funcion para imprimir la fecha
        /// </summary>
        public void imprimir()
        {
            string s;
            s = dia + " de " + mes + " de " + ano + ", ";
            if (this.hora < 10)
            {
                s = s + "0" + hora;
            }
            else
            {
                s = s + hora;
            }
            if (this.minutos < 10)
            {
                s = s + ":0" + minutos;
            }
            else
            {
                s = s + ":" + minutos;
            }
            if (this.segundos < 10)
            {
                s = s + ":0" + segundos;
            }
            else
            {
                s = s + ":" + segundos;
            }

            s = s + " horas";
            
            Console.WriteLine(s);
        }
    }
}
