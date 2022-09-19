using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtreKerekit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bekér egy pénzösszeget és a legkisebb fizetőeszköznek (5 Ft) megfelelőre kerekíti.

            double bePenz = PotizivSzam();
            double kerekitettErtek = Math.Round(bePenz / 5) * 5;
            Console.WriteLine($"A(z) {bePenz} Ft ötre kerekített értéke {kerekitettErtek} Ft");

            Console.ReadKey();
        }

        private static double PotizivSzam()
        {
            double visszateresiErtek;
            int leptet = 0;
            Console.Write("Adj meg egy pénzösszeget: ");
            do
            {
                if (leptet > 0)
                {
                    Console.Write("Hibás érték! Adj meg újat: ");
                }
                leptet++;

            } while (!double.TryParse(Console.ReadLine(), out visszateresiErtek) || visszateresiErtek < 0);
            return visszateresiErtek;
        }
    }
}
