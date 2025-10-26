using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero;
            var entero2 = 3.1416;
            int valor = args.Length > 0 ? Convert.ToInt32(args[0]) : 0;
            //verdadero ? falso
            if(valor == 0)
            {
                Console.WriteLine("no se especifico un valor");

            }else if(valor == 1){
                Console.WriteLine("hola");
            }
            else if (valor == 1)
            {
                Console.WriteLine("adios");
            }
        }
    }
}