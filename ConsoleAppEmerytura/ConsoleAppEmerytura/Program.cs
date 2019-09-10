using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmerytura
{
    class Program
    {
        const int wiekEmerytalny = 67;

        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja EMERYTURA");

            Console.WriteLine("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}");

            Console.WriteLine("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < 67)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem.");
            }

            Console.ReadKey();
        }
    }
}