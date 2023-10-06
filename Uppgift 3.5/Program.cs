using System;
namespace Uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räkne sätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string svar = Console.ReadLine();

            if (svar == "1")
            {
                double summa = tal1 + tal2;
                Console.WriteLine(tal1 + " + " + tal2 + " = " + summa);
            }
            else if (svar == "2")
            {
                double differens = tal1 - tal2;
                Console.WriteLine(tal1 + " - " + tal2 + " = " + differens);
            }
            else if (svar == "3")
            {
                double produkt = tal1 * tal2;
                Console.WriteLine(tal1 + " * " + tal2 + " = " + produkt);
            }
            else if (svar == "4")
            {
                double kvot = tal1 / tal2;
                Console.WriteLine(tal1 + " / " + tal2 + " = " + kvot);
            }
            else
            {
                Console.WriteLine("Vänligen skriv in ett nummer mellan 1 till 4.");
            }
            Console.ReadKey();
        }
    }
}