using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int kup, kare;
            do
            {
                a++;
                kup = a * a * a ;
                kare = a * a;
                Console.WriteLine($"{a} sayisinin karesi:{kare} ve küpü={kup} 'dür.");
                
            } while (a<10);
            Console.ReadKey();
        }
    }
}
