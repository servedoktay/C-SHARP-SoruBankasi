using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, enb, enk;

            Console.WriteLine("s1:");
            s1=int.Parse(Console.ReadLine());

            Console.WriteLine("s2:");
            s2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("s4:");
            s3 = int.Parse(Console.ReadLine());

            enb = s1;
            enk = s1;
            if (s1 > s2) enb = s1;
            else if (s1 < s2) enb = s2;
            else if (s3 > s1) enb = s3;

            if (s1 < s2) enk = s1;
            else if (s1 > s2) enk = s2;
            else if (s3 < s1) enk = s3;

            Console.WriteLine(enb);
            Console.WriteLine(enk);

            Console.ReadKey();


        }
    }
}
