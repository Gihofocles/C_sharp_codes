/*
 * Hernandez Orozco Cesar Gibran
 * Programacion avanzada
 * 2022640421
 * examen2.cs
 * Cajero automatico con interfaz de usuario
 */

using System.Net.NetworkInformation;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public static string path = Path.Combine(Directory.GetCurrentDirectory(), "basedatos.txt");
        public static string pathticket = Path.Combine(Directory.GetCurrentDirectory(), "ticket.txt");
        //public static string basedatos = @"E:\Programas\Onedrive\upiita\3 semestre\progra\Examen2\basededatos.txt";
        public static string basedatos = path;
        public static string ticket = pathticket;
        public static string cuentas;
        public static string pine;
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Accede(object sender, EventArgs e)
        {
            if (File.Exists(basedatos))
            {
                string[] texto = File.ReadAllLines(basedatos);
                string[,] tabla = new string[texto.Length+1, 4];
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
                foreach(var Numerocuenta in tabla)
                {
                    
                    if (cuenta.Text.Length == 6)
                    {
                        if (cuenta.Text == Numerocuenta)
                        {
                            if (pin.Text.Length == 4)
                            {
                                if (pin.Text == tabla[g, 1])
                                {
                                    Form2 ventana2 = new Form2();
                                    this.Hide();
                                    cuentas = cuenta.Text;
                                    pine = pin.Text;
                                    ventana2.Show();
                                }
                                else
                                {
                                    cuenta.Text = " combinacion No valida";
                                    pin.Text = " intente de nuevo";
                                }
                            }
                            else
                            {
                                pin.Text = "Pin de tamaño incorrecto";
                            }

                        }
                    }
                    else
                    {
                        cuenta.Text = "No de cuenta incorrecto";
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
                int a = 0;
            }
        }

        private void iniciame(object sender, EventArgs e)
        {
            if (!File.Exists(basedatos))
            {
                string[] basedatoscrear = new string[30];
                basedatoscrear[0] = "640103,0103,CHRISTOPHER,5000";
                basedatoscrear[1] = "640001,0001,LUIS EDUARDO,5000";
                basedatoscrear[2] = "640461,0461,KEVIN,5000";
                basedatoscrear[3] = "640088,0088,ANA KAREN,5000";
                basedatoscrear[4] = "640105,0105,CRISTIAN,5000";
                basedatoscrear[5] = "640088,0088,CANDIDO,5000";
                basedatoscrear[6] = "640003,0003,ANTONIO DE JESUS,5000";
                basedatoscrear[7] = "640164,0164,CARMEN NATALY,5000";
                basedatoscrear[8] = "360096,0096,ALEJANDRO,5000";
                basedatoscrear[9] = "640174,0174,GESSURI JAFETH,5000";
                basedatoscrear[10] = "350952,0952,RICARDO,5000";
                basedatoscrear[11] = "360109,0109,OSCAR JOEL,5000";
                basedatoscrear[12] = "640375,0375,ARTURO,5000";
                basedatoscrear[13] = "640419,0419,JORGE ISAAC,5000";
                basedatoscrear[14] = "361609,1609,HUMBERTO,5000";
                basedatoscrear[15] = "640276,0276,DIEGO ARMANDO,5000";
                basedatoscrear[16] = "640421,0421,CESAR GIBRAN,5000";
                basedatoscrear[17] = "640478,0478,SANDRA STEPHANY,5000";
                basedatoscrear[18] = "640246,0246,ANDREA SOCORRO,5000";
                basedatoscrear[19] = "640275,0275,LUIS ENRIQUE,5000";
                basedatoscrear[20] = "640412,0412,ISAAC JAIR,5000";
                basedatoscrear[21] = "640387,0387,GUILLERMO,5000";
                basedatoscrear[22] = "640019,0019,IVAN JOSE,5000";
                basedatoscrear[23] = "640061,0061,RICARDO ALAN,5000";
                basedatoscrear[24] = "640071,0071,CARLOS EDUARDO,5000";
                basedatoscrear[25] = "351483,1483,CHRISTIAN LEONARDO,5000";
                basedatoscrear[26] = "640467,0467,ANDRES,5000";
                basedatoscrear[27] = "640535,0535,ALEJANDRO,5000";
                basedatoscrear[28] = "640518,0518,JOSUE FIDENCIO,5000";
                basedatoscrear[29] = "640011,0011,BENJAMIN,5000";

                using (var s = new StreamWriter(basedatos))
                {
                    for (int i = 0; i < 30; i++)
                    {
                        s.Write(basedatoscrear[i]);
                        s.Write('\n');
                    }
                    s.Flush();
                    s.Close();
                }
            }
            if (!File.Exists(ticket))
            {
                using (var s = new StreamWriter(ticket))
                {
                    s.Flush();
                    s.Close();
                }
            }
        }
    }
}