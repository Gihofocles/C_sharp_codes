using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    
    public partial class Form5 : Form
    {
        public string vieja = Form1.pine;
        public string nueva;
        public string ticket = Form1.ticket;
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(contravieja.Text == vieja)
            {
                if(int.TryParse(contranueva.Text,out int n) == true)
                {
                    if(contranueva.Text.Length == 4) 
                    {
                        nueva = contranueva.Text;
                        using (var s = new StreamWriter(ticket))
                        {
                            s.Write("Nombre: " + Form2.nombre);
                            s.Write('\n');
                            s.Write("No de cuenta: " + Form2.cuenta);
                            s.Write('\n');
                            s.Write("Contraseña cambiada");
                            s.Flush();
                            s.Close();
                        }
                        Form4 recibo = new Form4();
                        DialogResult diagrecibo = recibo.ShowDialog(this);
                        if (diagrecibo == DialogResult.OK)
                        {
                            recibo.Close();
                        }
                        DialogResult = DialogResult.OK;
                    }
                    
                }                
            }
            else
            {
                contravieja.Text = "Contraseña no coincide con la anterior";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
