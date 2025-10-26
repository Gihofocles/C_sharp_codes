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
    
    public partial class Form4 : Form
    {
        public static string hoy = DateTime.Now.ToString("MMMM_M_h_mm_ss");
        public static string nombrearchivo = "tiket_" + hoy + ".txt";
        public static string ticketgenerado = Path.Combine(Directory.GetCurrentDirectory(), nombrearchivo);
        public string ticket = Form1.ticket;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult= DialogResult.OK;
        }
        private void iniciarecibo(object sender, EventArgs e)
        {
            hoy = DateTime.Now.ToString("MMMM_M_h_mm_ss");
            nombrearchivo = "tiket_" + hoy + ".txt";
            ticketgenerado = Path.Combine(Directory.GetCurrentDirectory(), nombrearchivo);

            if (File.Exists(ticket))
            {
                string[] textorecibo = File.ReadAllLines(ticket);
                for(int i = 0;i<textorecibo.Length;i++)
                {
                    textBox1.Text = textBox1.Text + textorecibo[i] + Environment.NewLine;
                }
                if (!File.Exists(ticketgenerado))
                {
                    using (var s = new StreamWriter(ticketgenerado))
                    {
                        for(int i = 0;i< textorecibo.Length; i++)
                        {
                            s.Write(textorecibo[i]);
                            s.Write('\n');
                        }
                        s.Flush();
                        s.Close();
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
