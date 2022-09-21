using System;

namespace Energieprijzen_2022
{
    class Program
    {
        static void Main(string[] args) // © Joaquin Goossens
        {
            double vermogen, tijd, prijs, jaar, totaalprijs;

            // Intro
            Console.WriteLine("Berkent gemiddelde kostprijs computer op jaarbasis");
            Console.WriteLine();
            // Invoer
            Console.Write("Gemiddeld vermogen (in watt) : ");
            vermogen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gemiddelde computertijd per dag (in uur) : ");
            tijd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prijs energieleverancier (in euro per kWh) : ");
            prijs = Convert.ToDouble(Console.ReadLine());

            // Formule
            jaar = tijd * 365;
            totaalprijs = vermogen / 1000 * jaar * prijs;

            Console.WriteLine();    
            Console.WriteLine("De gemiddelde kostprijs voor je computer op jaarbasis is: {0} euro", totaalprijs);
            Console.ReadLine();
        }
    }
}
