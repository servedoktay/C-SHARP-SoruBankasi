using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_CozumluSoruBank_bolum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tambilet = 10, cocukBilet = 7; 

            int yetiskinS, ogrenciS, maliyet;
            Console.WriteLine("Yetiskin Sayisi");
            yetiskinS = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cocuk Sayisi");
            ogrenciS = Int32.Parse(Console.ReadLine());

            maliyet = tambilet * yetiskinS + cocukBilet * ogrenciS;
            Console.WriteLine(maliyet);
            Console.WriteLine($"{yetiskinS} yetiskin ve {ogrenciS} ogrenci icin " +
                $"bilet aldiniz borcunuz={maliyet}");
            Console.ReadKey();

           
        }
    }
}
