using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form2 : Form
    {
        public static string basedatos = Form1.basedatos;
        public static string ticket = Form1.ticket;
        public static string cuenta = Form1.cuentas;
        public static string nombre;
        public static string saldo;

        public Form2()
        {
            InitializeComponent();
        }

        private void VentanaCargada(object sender, EventArgs e)
        {
            if (File.Exists(basedatos))
            {
                string[] texto = File.ReadAllLines(basedatos);
                string[,] tabla = new string[texto.Length, 4];
                string[] r = new string[50];
                int i = 0;
                foreach (var renglon in texto)
                {
                    r = renglon.Split(',');
                    tabla[i, 0] = r[0];
                    tabla[i, 1] = r[1];
                    tabla[i, 2] = r[2];
                    tabla[i, 3] = r[3];
                    i++;
                }
                i = 0;
                int g = 0;
                foreach (var Numerocuenta in tabla)
                {

                    if (cuenta.Length == 6)
                    {
                        if (cuenta == Numerocuenta)
                        {
                            datos1.Text = ("Usuario: " + tabla[g, 2]);
                            nombre = tabla[g, 2];
                            datos2.Text = ("saldo: " + tabla[g, 3]);
                            saldo = tabla[g, 3];
                        }
                    }
                    if (i == 3)
                    {
                        g++;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                }
            }
        }

        public void CambiarContrasena(object sender, EventArgs e)
        {
            Form5 contra = new Form5();
            DialogResult diagcontra = contra.ShowDialog(this);
            if (diagcontra == DialogResult.OK)
            {
                if (File.Exists(basedatos))
                {
                    string[] texto = File.ReadAllLines(basedatos);
                    string[,] tabla = new string[texto.Length, 4];
                    string[] r = new string[50];
                    int i = 0;
                    foreach (var renglon in texto)
                    {
                        r = renglon.Split(',');
                        tabla[i, 0] = r[0];
                        tabla[i, 1] = r[1];
                        tabla[i, 2] = r[2];
                        tabla[i, 3] = r[3];
                        i++;
                    }
                    i = 0;
                    int g = 0;
                    foreach (var Numerocuenta in tabla)
                    {

                        if (cuenta.Length == 6)
                        {
                            if (cuenta == Numerocuenta)
                            {
                                tabla[g, 1] = contra.nueva;
                            }
                        }
                        if (i == 3)
                        {
                            g++;
                            i = 0;
                        }
                        else
                        {
                            i++;
                        }

                    }
                    string[] tablaplana = new string[texto.Length];
                    int k = 0;
                    i = 0;
                    g = 0;
                    foreach(var linea in tabla)
                    {
                        tablaplana[g] =  tablaplana[g]+ tabla[g,i] + ",";
                        if (i == 3)
                        {
                            g++;
                            i = 0;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    i = 0;
                    foreach (var elemento in tablaplana)
                    {
                        tablaplana[i] = elemento.Remove(elemento.Length-1);
                        i++;
                    }
                    contra.Close();
                    using(var s = new StreamWriter(basedatos))
                    {
                        for(i = 0; i< texto.Length; i++)
                        {
                            s.Write(tablaplana[i]);
                            s.Write('\n');
                        }
                        s.Flush();
                        s.Close();
                    }
                    
                }

            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 retiro = new Form3();
            DialogResult diagretiro = retiro.ShowDialog(this);
            if(diagretiro == DialogResult.OK)
            {
                string[] texto = File.ReadAllLines(basedatos);
                string[,] tabla = new string[texto.Length, 4];
                string[] r = new string[50];
                int i = 0;
                foreach (var renglon in texto)
                {
                    r = renglon.Split(',');
                    tabla[i, 0] = r[0];
                    tabla[i, 1] = r[1];
                    tabla[i, 2] = r[2];
                    tabla[i, 3] = r[3];
                    i++;
                }
                i = 0;
                int g = 0;
                foreach (var Numerocuenta in tabla)
                {

                    if (cuenta.Length == 6)
                    {
                        if (cuenta == Numerocuenta)
                        {
                            tabla[g, 3] = retiro.cantidadretiro;
                            saldo = retiro.cantidadretiro;
                        }
                    }
                    if (i == 3)
                    {
                        g++;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                }
                string[] tablaplana = new string[texto.Length];
                int k = 0;
                i = 0;
                g = 0;
                foreach (var linea in tabla)
                {
                    tablaplana[g] = tablaplana[g] + tabla[g, i] + ",";
                    if (i == 3)
                    {
                        g++;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
                i = 0;
                foreach (var elemento in tablaplana)
                {
                    tablaplana[i] = elemento.Remove(elemento.Length - 1);
                    i++;
                }
                
                retiro.Close();
                using (var s = new StreamWriter(basedatos))
                {
                    for (i = 0; i < texto.Length; i++)
                    {
                        s.Write(tablaplana[i]);
                        s.Write('\n');
                    }
                    s.Flush();
                    s.Close();
                }
                
                datos2.Text = saldo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 recibo = new Form4();
            using (var s = new StreamWriter(ticket))
            {
                s.Write("Consulta de saldo");
                s.Write('\n');
                s.Write("Nombre: " + Form2.nombre);
                s.Write('\n');
                s.Write("No de cuenta: " + Form2.cuenta);
                s.Write('\n');
                s.Write("Saldo: " + Form2.saldo);
                s.Write('\n');
                s.Flush();
                s.Close();
            }
            DialogResult diagrecibo = recibo.ShowDialog(this);
            if (diagrecibo == DialogResult.OK)
            {
                recibo.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }
    }
}
