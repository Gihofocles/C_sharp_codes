using ConsoleApp3.Clases;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Empleado emp1 = new Empleado(3,"roberto","hernandez");
            List<Empleado> ListaNomina = new List <Empleado>();
            Random rnd = new Random();
            for(int i = 0; i < 3; i++)
            {
                //string empleado;
                ListaNomina.Add(new Empleado(rnd.Next()));
            }

            foreach(var Empleado in ListaNomina)
            {
                Console.WriteLine(Empleado.tostring());
            }
            /**
            Auto toyota = new Auto();
            toyota.Anio = 2022;
            toyota.Modelo = "supra";
            toyota.Color = "Pistache";
            toyota.Frenar();**/

        }

        private static List<T> List<T>()
        {
            throw new NotImplementedException();
        }
    }
}