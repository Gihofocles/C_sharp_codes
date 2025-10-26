using System.Drawing.Drawing2D;

namespace Practica6
{
    public partial class Form1 : Form
    {
        private Bitmap img;
        private Bitmap imgres;
        public Form1()
        {
            InitializeComponent();
        }
        private void Abrir(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png|Imagen BMP|*.bmp|Todos los demas|*.*";
            op.FileName = String.Empty;
            var resp = op.ShowDialog();
            if (resp == DialogResult.OK)
            {
                img = new Bitmap(op.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void Escala_de_grises(object sender, EventArgs e)
        {
            Bitmap imgG = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);
                    var promedio = (pixel.R + pixel.G + pixel.B) / 3;
                    imgG.SetPixel(x, y, Color.FromArgb(pixel.A, promedio, promedio, promedio));
                }
            }
            pictureBox2.Image = imgG;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imgG;
        }
        private void Negativo(object sender, EventArgs e)
        {
            Bitmap imgneg = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);
                    //var color = Color.FromArgb((pixel.R - 255) , (pixel.G - 255) , (pixel.B - 255));
                    var promedio = (pixel.R + pixel.G + pixel.B);
                    imgneg.SetPixel(x, y, Color.FromArgb(pixel.A, 255-pixel.R, 255-pixel.G, 255-pixel.B));
                }
            }
            pictureBox2.Image = imgneg;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imgneg;
        }
        
        private void Rotacion_90_izquierda(object sender, EventArgs e)
        {
            Bitmap imgizq = new Bitmap(img.Height, img.Width);
            int h = 0;
            for (int x = 0; x < img.Width; x++)
            {
                
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x,y);
                    imgizq.SetPixel(y,h, pixel);
                }
                h = img.Width - x-1;
            }
            pictureBox2.Image = imgizq;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imgizq;
        }
        private void Rotacion_90_derech(object sender, EventArgs e)
        {
            Bitmap imgder = new Bitmap(img.Height, img.Width);
            int h = 0;
            for (int x = 0; x < img.Width; x++)
            {

                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);
                    imgder.SetPixel(y, h, pixel);
                }
                h = img.Width - x - 1;
            }

            Bitmap imgder2 = new Bitmap(imgder.Height, img.Width);
            h = 0;
            for (int x = 0; x < imgder.Width; x++)
            {

                for (int y = 0; y < imgder.Height; y++)
                {
                    var pixel = imgder.GetPixel(x, y);
                    imgder2.SetPixel(y, h, pixel);
                }
                h = imgder.Width - x - 1;
            }

            Bitmap imgder3 = new Bitmap(imgder2.Height, img.Width);
            h = 0;
            for (int x = 0; x < imgder2.Width; x++)
            {

                for (int y = 0; y < imgder2.Height; y++)
                {
                    var pixel = imgder2.GetPixel(x, y);
                    imgder3.SetPixel(y, h, pixel);
                }
                h = imgder2.Width - x - 1;
            }


            pictureBox2.Image = imgder3;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imgder3;
        }

        private void Espejo_vertical(object sender, EventArgs e)
        {
            Bitmap imgver = new Bitmap(img.Width, img.Height);
            int h = 0;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);
                    imgver.SetPixel(x, img.Height-y-1, pixel);
                }
            }
            pictureBox2.Image = imgver;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imgver;
        }

        private void Espejo_horizontal(object sender, EventArgs e)
        {
            Bitmap imghor = new Bitmap(img.Width, img.Height);
            int h = 0;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var pixel = img.GetPixel(x, y);
                    imghor.SetPixel(img.Width-x-1,y, pixel);
                }
            }
            pictureBox2.Image = imghor;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imgres = imghor;
        }
        private void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png|Imagen BMP|*.bmp|Todos los demas|*.*";
            if(save.ShowDialog() == DialogResult.OK)
            {
                imgres.Save(save.FileName);
            }
        }
        private void Blur(object sender, EventArgs e)
        {

        }
        private void Nitidez(object sender, EventArgs e)
        {

        }
    }
}