using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBank_Soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tus;
            Console.WriteLine("Klavyeden Bİr Tuşa Basiniz");
            tus= Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine(tus.Key.ToString() +" Tuşuna bastiniz");
            Console.ReadKey();
        }
    }
}
