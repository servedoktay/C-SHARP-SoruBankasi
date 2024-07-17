using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen iki sayıyı sadece cıkartma ve toplama kullanarak çarpma işlemmi yaptırtma while ile
            int sayi1, sayi2, toplam = 0, sayi2tut, sayi1tut; ;
            Console.Write("Sayi 1:");
            sayi1=Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Sayi 2:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = 0;
              if (sayi2 < 0)
            {
                sayi2 = -sayi2;
                sayi1= -sayi1;
            }
            
            while (sayi2 > 0)
            {
                toplam = toplam + sayi1;
                sayi2--;
            }
            Console.WriteLine($"Sayilarin Carpimi..:{toplam}");



            Console.ReadKey();
        }
    }
}
