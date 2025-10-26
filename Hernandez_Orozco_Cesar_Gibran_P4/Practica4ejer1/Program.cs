using Practica4ejer1.Clases;

namespace Practica4ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputadoraPortatil p1 = new ComputadoraPortatil(16,"intel","hp",5);
            ComputadoraPortatil p2 = new ComputadoraPortatil(4, "amd", "dell",6);
            ComputadoraPortatil p3 = new ComputadoraPortatil(8, "intel", "msi",7);
            TelefonoInteligente i1 = new TelefonoInteligente(3, "a", "huawei", "1080p");
            TelefonoInteligente i2 = new TelefonoInteligente(4, "b", "xiaomi", "1440");
            TelefonoInteligente i3 = new TelefonoInteligente(5, "c", "apple", "4k");

            p1.Imprimir();
            Console.WriteLine("\n---------------------------\n");
            p2.Imprimir();
            Console.WriteLine("\n---------------------------\n");
            p3.Imprimir();
            Console.WriteLine("\n---------------------------\n");
            i1.Imprimir();
            Console.WriteLine("\n---------------------------\n");
            i2.Imprimir();
            Console.WriteLine("\n---------------------------\n");
            i3.Imprimir();
            Console.WriteLine("\n---------------------------\n");

            p1.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");
            p2.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");
            p3.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");
            i1.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");
            i2.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");
            i3.EnviarCorreo();
            Console.WriteLine("\n---------------------------\n");


        }
    }
}