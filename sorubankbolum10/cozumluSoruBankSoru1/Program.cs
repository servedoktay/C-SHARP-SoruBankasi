using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazdır();
            Console.ReadKey();
        }
        public static void Yazdır()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Yazdı");
            }
        }
    }
}
