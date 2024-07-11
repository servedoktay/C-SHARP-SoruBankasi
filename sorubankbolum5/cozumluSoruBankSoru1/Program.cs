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
            int sayi;
            Console.Write("Sayi Girin");
            sayi=Convert.ToInt32(Console.ReadLine());

            if (sayi == 10) Console.WriteLine("Sayi 10'a eşittir.");
            else if (sayi < 10) Console.WriteLine("Sayi 10dan Kucuk");
            else if (sayi > 10) Console.WriteLine("Sayi 10 dan Buyuk");
            else Console.WriteLine("Hata");

            Console.ReadKey();
        }
    }
}
