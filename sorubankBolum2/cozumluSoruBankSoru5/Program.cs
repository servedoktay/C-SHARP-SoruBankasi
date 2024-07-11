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
            int s1, s2, s3, s4, toplam = 0, ort;
            Console.WriteLine("4 SAyi Giriniz");
            s1=Int16.Parse(Console.ReadLine());
            s2 = Int16.Parse(Console.ReadLine());
            s3 = Int16.Parse(Console.ReadLine());
            s4 = Int16.Parse(Console.ReadLine());
            
            toplam=s1+s2+ s3 + s4;
            ort = toplam / 4;

            Console.WriteLine($"Toplam={toplam}");
            Console.WriteLine($"Ortalama={ort}");

            Console.ReadKey();
        }
    }
}
