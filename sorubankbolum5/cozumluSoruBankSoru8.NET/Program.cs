using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru8.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.WriteLine("Sayi");
            //sayi=int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} girdiniz",sayi<10 ?"kucuk":(sayi>10"buyuk":(sayi==10"esit":"hata")));
            //Console.ReadKey();

            int sayi;
            Console.WriteLine("Sayı Girin:");
            sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} girdiniz", sayi < 10 ? "küçük" : (sayi > 10 ? "büyük" : (sayi == 10 ? "eşit" : "hata")));

            Console.ReadKey();

        }
    }
}
