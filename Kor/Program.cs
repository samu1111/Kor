using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sugar, terulet, kerulet;

            Console.Write("Kérem a kör sugarát: ");

            string szoveg = Console.ReadLine();
            sugar = Convert.ToDouble(szoveg);
            

            //r*r*PI, 2*r*PI//

            terulet = Math.Pow(sugar, 2) * Math.PI;
            kerulet = 2 * sugar * Math.PI;

            Console.WriteLine($"Terület: {terulet}");
            Console.WriteLine($"Kerület: {kerulet}");


            Console.ReadKey();

        }
    }
}
