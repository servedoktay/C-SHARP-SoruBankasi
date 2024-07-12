using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, enb, enk;
            Console.WriteLine("S1:");
            s1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("S2:");
            s2=Convert.ToInt32(Console.ReadLine());

            enb = s1; enk = s1;
            if (s2 > enb) enb = s2;
            else if (s2 < enk) enk = s2;
            else if(s2 == enk) Console.WriteLine("Esit Degerler");
            Console.WriteLine("Aralarındaki Cift Sayilar");
            for (int i = enk; i < enb; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                else continue;
            }
            Console.ReadKey();
        }
    }
}
