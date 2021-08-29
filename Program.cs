using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string Berro;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Você diz: ");
            Console.ResetColor();
            Berro = Console.ReadLine();
            Berro = Berro.ToUpper();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Eu grito: ");
            Console.ResetColor();
            Console.WriteLine(Berro);
            Console.WriteLine();
        }
    }
}
