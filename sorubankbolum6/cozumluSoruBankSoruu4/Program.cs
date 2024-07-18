using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoruu4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[5];
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++) 
            {
                Console.WriteLine($"{i+1} .sayiyi giriniz.");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());

                if (sayilar[i]%10==0)
                {
                    sayac++;
                }
            }
            Console.WriteLine($"{sayac} tane sayinın son basamağı 0 dır");
            Console.ReadKey();

        }
    }
}
