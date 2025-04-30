using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Small Carpets:");
            double smallcarpets = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nuomber Of Larg Carpet:");
            double largCarpets = Convert.ToDouble(Console.ReadLine());
            const double tax = 0.06;
            smallcarpets = smallcarpets * 25;
            largCarpets = largCarpets * 35;
        
            
            Console.WriteLine($"cost: ${smallcarpets+largCarpets}");
            Console.WriteLine($"Tax: ${(smallcarpets + largCarpets) * tax}");

            Console.WriteLine($"total estimate:{(smallcarpets + largCarpets) + ((smallcarpets + largCarpets) * tax)}");
            Console.WriteLine("This estimate is Valid for 30 days");
        }

    }
}
