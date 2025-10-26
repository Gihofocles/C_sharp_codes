using System.Security.Permissions;
using System.Windows.Forms;
using OpenCvSharp;

namespace Practica7
{
    public partial class Form1 : Form
    {
        //private Bitmap img;
        VideoCapture video = new VideoCapture();
        public Form1()
        {
            InitializeComponent();
            Mat imgp = new Mat();
            video.Read(imgp);
            pictureBox1.Image=imgp;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        
    }
}