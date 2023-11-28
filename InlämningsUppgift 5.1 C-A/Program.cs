using System;
namespace InlämningsUppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet skriver ut ett par meningar.");
            string[] meningar = { "Jag tycker om att träna.", "Gillar också mat.", "Detta är sista meningen." };
            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(meningar[i]);
            }
            Console.ReadKey();
        }
    }
}