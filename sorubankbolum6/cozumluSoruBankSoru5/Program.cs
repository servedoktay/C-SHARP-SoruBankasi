using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace cozumluSoruBankSoru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int toplam = 0, aralikdakiDegerS = 0;
            Random rasge = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i]=rasge.Next(1,1000);
            }
            
            for (int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                if (sayilar[i] > 500 && sayilar[i] < 600)
                    toplam += sayilar[i];
               else if (sayilar[i] > 100 && sayilar[i] < 500)
                    aralikdakiDegerS++;

            }
            Console.WriteLine($"500 ile 600 arasindaki sayilarin toplami=   {toplam}");
            Console.WriteLine($"100 ile 500 arasindaki sayilarin sayisi= {aralikdakiDegerS} ");
            Console.ReadKey();
        }
    }
}
