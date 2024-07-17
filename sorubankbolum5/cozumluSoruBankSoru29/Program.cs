using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen sayının farktorıyelını bulup ekrana yazdıran program while ile
            int sayi, faktöriyet, tut;
            Console.WriteLine("Bir Sayi Giriniz");
            sayi=int.Parse(Console.ReadLine());
            tut = sayi;
            faktöriyet = 1;
            while (sayi > 0)
            {
                faktöriyet = faktöriyet * sayi;
                sayi--;
            }
            Console.WriteLine($"{tut} sayisinin faktröriyeli:{faktöriyet}'dir");
            Console.ReadKey();

        }
    }
}
