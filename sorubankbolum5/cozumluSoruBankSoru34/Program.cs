using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dısarıdan gırlıen 10 sayının kac tanesı 3 basamaklı onu hesaplat
            int sayi, basamak=0, islem, limit=0, ucbas=0;
            do
            {
                limit++;
                Console.WriteLine($"{limit} . Sayiyi Giriniz..:");
                sayi = Convert.ToInt32(Console.ReadLine());
                islem = sayi % 10;
                basamak++;
                if (basamak == 3)
                {
                    ucbas++;
                }
            } while (limit < 10);
            Console.WriteLine($"Üc basamaklı Sayi Sayisi:{ucbas-1}");
            Console.ReadKey();


        }
    }
}
