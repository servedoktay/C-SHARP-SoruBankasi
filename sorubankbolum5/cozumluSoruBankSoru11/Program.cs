using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int s1, s2,sonuc=0;
            char secim;
            Console.WriteLine("S1=");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S2=");
            s2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Secimler");
            Console.Write("Toplama=+\n");
            Console.Write("Çikartma=-\n");
            Console.Write("Çarpma=*\n");
            Console.Write("Bölme=/\n");
            secim=Convert.ToChar(Console.ReadKey().KeyChar);

            switch (secim)
            {
                case '+':sonuc = s1 + s2;break;
                case '-': sonuc = s1 - s2; break;
                case '*': sonuc = s1 * s2; break;
                case '/': sonuc = s1 / s2; break;

                default: Console.WriteLine("Hata"); break;

            }
            Console.WriteLine($"{secim} islemi yaptiniz \nSonuc={sonuc}");
            Console.ReadKey();


        }
    }
}
