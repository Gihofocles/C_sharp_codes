using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form3 : Form
    {
        public string pin = Form1.pine;
        public string ticket = Form1.ticket;
        public string cantidadretiro;
        public static string cantidadretiro2;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == pin)
            {
                if ((double.Parse(cantidad.Text))<(double.Parse(Form2.saldo)))
                {
                    cantidadretiro = (-double.Parse(cantidad.Text) + double.Parse(Form2.saldo)).ToString();
                    cantidadretiro2 = cantidad.Text;
                    Form4 recibo = new Form4();
                    using (var s = new StreamWriter(ticket))
                    {
                        s.Write("Retiro exitoso");
                        s.Write('\n');
                        s.Write("Nombre: " + Form2.nombre);
                        s.Write('\n');
                        s.Write("No de cuenta: " + Form2.cuenta);
                        s.Write('\n');
                        s.Write("Saldo previo: " + Form2.saldo);
                        s.Write('\n');
                        s.Write("Monto de retiro: " + Form3.cantidadretiro2);
                        s.Write('\n');
                        s.Flush();
                        s.Close();
                    }
                    DialogResult diagrecibo = recibo.ShowDialog(this);
                    if (diagrecibo == DialogResult.OK)
                    {
                        recibo.Close();
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    cantidad.Text = "Saldo insuficiente";
                    textBox2.Text = "";
                }
                
            }
            else
            {
                textBox2.Text = "Pin invalido";
            }
        }
    }
}
