using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text.Json;
using static Practica5.Form1;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public enum Operaciones
        {
            Ninguna,
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Potencia,
            Cuadrado,
            Raiz
        }
        private double? _op1;
        private double? _res;
        private Operaciones _op2;
        private int ind=0;
        public Form1()
        {
            InitializeComponent();
            _op1 = null;
            _res = null;
            _op = Operaciones.Ninguna;
        }
        private void AgregarNumero(object sender, EventArgs e)
        {
            var numero = ((Button)sender);
            if (texto.Text == "")
            {
                texto.Text = "0";
            }
            if (texto.Text == "0")
            {
                texto.Text = "";
            }
            if (texto.Text == "Error de sintaxis")
            {
                texto.Text = "";
            }
            if ((numero.Text.Equals("1")) || (numero.Text.Equals("2")) || (numero.Text.Equals("3")) || (numero.Text.Equals("4")) || (numero.Text.Equals("5")) || (numero.Text.Equals("6")) || (numero.Text.Equals("7")) || (numero.Text.Equals("8")) || (numero.Text.Equals("9")) || (numero.Text.Equals("0")))
            {
                texto.Text += numero.Text;
            }
            if (numero.Text.Equals("x²"))
            {
                if (texto.Text != "")
                {
                    if ((texto.Text.EndsWith("²")) || (texto.Text.EndsWith("√")) || (texto.Text.EndsWith("^")) || (texto.Text.EndsWith("+")) || (texto.Text.EndsWith("-")) || (texto.Text.EndsWith("x")) || (texto.Text.EndsWith("/")) || (texto.Text.EndsWith(".")))
                    {
                    }
                    else
                    {
                        texto.Text += "²";
                    }

                }
            }
            if (numero.Text.Equals("y˟"))
            {
                if (texto.Text != "")
                {
                    if ((texto.Text.EndsWith("²")) || (texto.Text.EndsWith("√")) || (texto.Text.EndsWith("^")) || (texto.Text.EndsWith("+")) || (texto.Text.EndsWith("-")) || (texto.Text.EndsWith("x")) || (texto.Text.EndsWith("/")) || (texto.Text.EndsWith(".")))
                    {
                    }
                    else
                    {
                        texto.Text += "^";
                    }

                }
            }
            if ((numero.Text.Equals("x")) || (numero.Text.Equals("+")) || (numero.Text.Equals("-")) || (numero.Text.Equals("/")))
            {
                if (texto.Text != "")
                {
                    if ((texto.Text.EndsWith("√")) || (texto.Text.EndsWith("^")) || (texto.Text.EndsWith("+")) || (texto.Text.EndsWith("-")) || (texto.Text.EndsWith("x")) || (texto.Text.EndsWith("/")) || (texto.Text.EndsWith(".")))
                    {
                    }
                    else
                    {
                        texto.Text += numero.Text;
                        
                        if (numero.Text.Equals("x"))
                        {

                        }
                    }

                }
            }
            if (numero.Text.Equals("√") || (numero.Text.Equals(".")))
            {
                if ((texto.Text.EndsWith("²")) || (texto.Text.EndsWith("√")) || (texto.Text.EndsWith("^")) || (texto.Text.EndsWith(".")))
                {
                }
                else
                {
                    texto.Text += numero.Text;
                }
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void masmenos_Click(object sender, EventArgs e)
        {
        }
        private void borrar_Click(object sender, EventArgs e)
        {
        }

        private void ce_Click(object sender, EventArgs e)
        {
        }
        private void Igualar(object sender, EventArgs e)
        {
        }
        private void operaciones(Operaciones op)
        {
        }

    }
}