using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBank_Soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tus = 0;
            Console.WriteLine("Klavyeden Tuşa Basiniz");
            tus = Convert.ToInt32(Console.Read());

            Console.WriteLine($"Basilan Tusun ASCII karsiliği={tus}");
            Console.ReadKey();
        }
    }
}
