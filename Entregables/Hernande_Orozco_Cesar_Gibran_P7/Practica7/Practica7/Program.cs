/*
*Program.cs
*Practica 7
*Integrantes: 
*-Hernandez Orozco Cesar Gibran 
*-Hernández Rubio Sandra Stephany
*Boletas: 
*-2022640421
*-2022640478
*Fecha: 10/12/2022 
 
 */


using OpenCvSharp;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoCapture video = new VideoCapture(0);
            using Window ventana1 = new Window("BGR");
            using Window ventana2 = new Window("HSV");
            using Window ventana3 = new Window("MASK");
            using Window ventana4 = new Window("Configuracion");
            
            using Mat element = Cv2.GetStructuringElement(MorphShapes.Ellipse, new Size(50, 50));
            using Mat element2 = Cv2.GetStructuringElement(MorphShapes.Ellipse, new Size(5, 5));

            Cv2.CreateTrackbar("Hmin", "Configuracion", 180);
            Cv2.CreateTrackbar("Smin", "Configuracion", 255);
            Cv2.CreateTrackbar("Vmin", "Configuracion", 255);

            Cv2.CreateTrackbar("Hmax", "Configuracion", 180);
            Cv2.CreateTrackbar("Smax", "Configuracion", 255);
            Cv2.CreateTrackbar("Vmax", "Configuracion", 255);

            Cv2.SetTrackbarPos("Hmin", "Configuracion", 66);
            Cv2.SetTrackbarPos("Smin", "Configuracion", 86);
            Cv2.SetTrackbarPos("Vmin", "Configuracion", 96);

            Cv2.SetTrackbarPos("Hmax", "Configuracion", 86);
            Cv2.SetTrackbarPos("Smax", "Configuracion", 197);
            Cv2.SetTrackbarPos("Vmax", "Configuracion", 227);


            while (Cv2.WaitKey(30) != 27)
            {
                using Mat img = new Mat();
                video.Read(img);
                using Mat imgblur = img.GaussianBlur(new Size(11, 11),22);
                using Mat imgbil = imgblur.BilateralFilter(20, 40, 10);
                using Mat imgfil = img.CvtColor(ColorConversionCodes.BGR2HSV);

                var hmin = Cv2.GetTrackbarPos("Hmin", "Configuracion");
                var smin = Cv2.GetTrackbarPos("Smin", "Configuracion");
                var vmin = Cv2.GetTrackbarPos("Vmin", "Configuracion");
                var hmax = Cv2.GetTrackbarPos("Hmax", "Configuracion");
                var smax = Cv2.GetTrackbarPos("Smax", "Configuracion");
                var vmax = Cv2.GetTrackbarPos("Vmax", "Configuracion");

                Vec3i low = new Vec3i(hmin, smin, vmin);
                Vec3i high = new Vec3i(hmax, smax, vmax);
                using Mat mask = imgfil.InRange(low, high);
                Cv2.Erode(mask, mask, element2);
                Cv2.Dilate(mask, mask, element2);
                Cv2.Dilate(mask, mask, element);
                Rect boundingbox = Cv2.BoundingRect(mask);
                img.Rectangle(boundingbox, new Scalar(0, 0, 255), 2);
                ventana3.ShowImage(mask);
                ventana1.ShowImage(img);
                ventana2.ShowImage(imgfil);

            }
        }
    }
}