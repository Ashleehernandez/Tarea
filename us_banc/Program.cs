using Da_banc;
using Neg_banc;

namespace us_banc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("====Bienvenido a el cajero===");
            Console.WriteLine();
            Console.WriteLine("Si ya tiene una cuenta inicie seccion ");
            Console.WriteLine("\n1 Iniciar seccion ");
            Console.WriteLine();
            Console.WriteLine("No tengo un cuenta ");
            Console.WriteLine("\n2 Registrarme ");

            opcion = int.Parse(Console.ReadLine()!);

            ////////////////////////////////////////////////////////////

            Console.WriteLine("==Bienvenido a el cajero Automatico ");
            Console.WriteLine("Elija lo que desee Realizar ");
            Console.WriteLine("\n1 : Depositar ");
            Console.WriteLine("\n2 : Retirar ");
            Console.WriteLine("\n3 Consultar Balance ");
            Console.WriteLine("\n4 Salir ");
            opcion = int.Parse(Console.ReadLine()!);

        }
    }
}
