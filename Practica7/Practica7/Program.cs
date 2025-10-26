using OpenCvSharp;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoCapture video = new VideoCapture(0);
            using Window window = new Window("Video");
            using Window ventana1 = new Window("BGR");
            using Window ventana2 = new Window("HSV");
            using Window ventana3 = new Window("MASK");
            using Window ventana4 = new Window("rgb");
            using Window ventana5 = new Window("col");

            using Mat element = Cv2.GetStructuringElement(MorphShapes.Ellipse, new Size(50, 50));
            using Mat element2 = Cv2.GetStructuringElement(MorphShapes.Ellipse, new Size(5, 5));

            Cv2.CreateTrackbar("h", "rgb", 180);
            Cv2.CreateTrackbar("s", "rgb", 255);
            Cv2.CreateTrackbar("v", "rgb", 255);
            



            while (Cv2.WaitKey(30) != 27)
            {
                using Mat img = new Mat();
                video.Read(img);
                using Mat imgblur = img.GaussianBlur(new Size(11, 11),22);
                using Mat imgbil = imgblur.BilateralFilter(20, 40, 10);
                using Mat imgfil = img.CvtColor(ColorConversionCodes.BGR2HSV);

                var h = Cv2.GetTrackbarPos("h","rgb");
                var s = Cv2.GetTrackbarPos("s", "rgb"); ;
                var v = Cv2.GetTrackbarPos("v", "rgb"); ;
                var hmin = 0;
                var smin = 0;
                var vmin = 0;

                using Mat col = new Mat(@"C:\Users\super\Pictures\img001.jpg");

                Cv2.Rectangle(col,new Rect(0,0,100,200),new Scalar(h,s,v));


                Vec3i color = new Vec3i(h, s, v);
                Vec3i colorvar = new Vec3i(hmin, smin, vmin);
                using Mat mask = imgfil.InRange(colorvar, color);
                Cv2.Erode(mask, mask, element2);
                Cv2.Dilate(mask, mask, element2);
                Cv2.Dilate(mask, mask, element);
                Rect boundingbox = Cv2.BoundingRect(mask);
                img.Rectangle(boundingbox, new Scalar(0, 0, 255), 2);
                ventana3.ShowImage(mask);
                ventana1.ShowImage(img);
                ventana2.ShowImage(imgfil);
                ventana5.ShowImage(col);
            }
        }
    }
}