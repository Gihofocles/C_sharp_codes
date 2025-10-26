/**
*Form1.cs
*Practica 5
*Nombre: Hernández Orozco Cesar Gibran
*Boleta: 2022640421
*Fecha: 8/11/2022
**/

namespace clc
{
    public enum Operaciones
    {
        Ninguna,
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Raiz,
        Potencia
    }
    public partial class Form1 : Form
    {
        private double? _op1;
        private Operaciones _op;
        public Form1()
        {
            InitializeComponent();
            _op1 = null;
            _op = Operaciones.Ninguna;
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {

        }
        private void BotonNum(object sender, EventArgs e)
        {
            AgregarNum(sender);
        }
        /// <summary>
        /// Funcion añadir numero
        /// </summary>
        /// <param name="sender"></param>
        private void AgregarNum(object sender)
        {
            var val = ((Button)sender).Text;
            _ = texto.Text.Equals("0") ? texto.Text = val :
                texto.Text += val;

        }
        /// <summary>
        /// Funcion simbolo negativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Masmenos(object sender, EventArgs e)
        {
            texto.Text = (double.Parse(texto.Text) * -1).ToString();
        }

        /// <summary>
        /// Funcion limpiar pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCe(object sender, EventArgs e)
        {
            texto.Text = "0";
        }

        /// <summary>
        /// Cuncion borrar operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonC(object sender, EventArgs e)
        {
            operaciones(Operaciones.Ninguna);
            texto.Text = "0";
            _op1 = null;
        }

        /// <summary>
        /// Funcion borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Borra(object sender, EventArgs e)
        {
            var borrar = texto.Text;
            if (!borrar.Equals("0"))
            {
                if (borrar.Length == 1)
                {
                    borrar = "0";
                }
                else
                {
                    borrar = borrar.Substring(0, borrar.Length - 1);
                }
                texto.Text = borrar;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                AgregarNum(e.KeyValue);
            }
        }
        /// <summary>
        /// Funcion para añadir un punto decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPunto(object sender, EventArgs e)
        {
            if (!texto.Text.Contains("."))
                texto.Text += ".";
        }
        private void BotonOperacion(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text.Equals("+"))
            {
                operaciones(Operaciones.Suma);
            }                
            if (btn.Text.Equals("-"))
            {
                operaciones(Operaciones.Resta);
            }                
            if (btn.Text.Equals("x"))
            {
                operaciones(Operaciones.Multiplicacion);
            }                
            if (btn.Text.Equals("/"))
            {
                operaciones(Operaciones.Division);
            }                
            if (btn.Text.Equals("√"))
            {
                texto.Text = Math.Sqrt(double.Parse(texto.Text)).ToString();
                _op1 = null;
            }
            if (btn.Text.Equals("x²"))
            {
                texto.Text = Math.Pow(double.Parse(texto.Text), 2).ToString();
                _op1 = null;
            }
        }
        private void operaciones(Operaciones op)
        {

            if (_op1 is null)
            {
                _op1 = double.Parse(texto.Text);
            }
            else
            {
                if (_op == Operaciones.Suma)
                {
                    _op1 += double.Parse(texto.Text);
                }                    
                if (_op == Operaciones.Resta)
                {
                    _op1 -= double.Parse(texto.Text);
                }                    
                if (_op == Operaciones.Multiplicacion)
                {
                    _op1 *= double.Parse(texto.Text);
                }                    
                if (_op == Operaciones.Division)
                {
                    _op1 /= double.Parse(texto.Text);
                }                    
            }
            _op = op;
            texto.Text = "0";
        }
        private void BotonIgual(object sender, EventArgs e)
        {
            if (_op1 != null)
            {
                if (_op == Operaciones.Suma)
                {
                    texto.Text = (_op1 + double.Parse(texto.Text)).ToString();
                }                    
                if (_op == Operaciones.Resta)
                {
                    texto.Text = (_op1 - double.Parse(texto.Text)).ToString();
                }
                if (_op == Operaciones.Multiplicacion)
                {
                    texto.Text = (_op1 * double.Parse(texto.Text)).ToString();
                }
                    
                if (_op == Operaciones.Division)
                {
                    texto.Text = (_op1 / double.Parse(texto.Text)).ToString();
                }
                    
                if (_op == Operaciones.Ninguna)
                {
                    texto.Text = "";
                }
                _op1 = null;
                _op = Operaciones.Ninguna;
            }
        }
        private void texto_Click(object sender, EventArgs e)
        {

        }
    }
}
