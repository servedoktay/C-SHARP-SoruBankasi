using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi ,toplam, ort;

            //toplam = 0;

            //  for (int i = 0; i < 16; i++)
            //  {
            //      Console.WriteLine($"{i + 1}.Sayi Girisi");
            //      sayi = Convert.ToInt32(Console.ReadLine());
            //      toplam = toplam + sayi;
            //      sayi = 0;
            //  }
            //  ort = toplam / 16;
            //  Console.WriteLine($"16 sayinin toplami={toplam}");
            //  Console.WriteLine($"Ort={toplam/16}");

            int toplam, ort;
            int[] sayilar = new int[16];
            toplam = 0;

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"{i + 1}.Sayi Girisi");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayilar[i];
               
            }
            ort = toplam / 16;
            Console.WriteLine($"16 sayinin toplami={toplam}");
            Console.WriteLine($"Ort={toplam / sayilar.Length}");


            Console.ReadKey();

        }   
    }
}
